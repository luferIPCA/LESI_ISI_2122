/*
 * RESTful Web API services
 * lufer
 * */
//JWT
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSwag;
using NSwag.Generation.Processors.Security;
using System.Linq;

namespace AulaHojeWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //para suportar XML
            services.AddMvc().AddXmlSerializerFormatters();
            //1º
            //Register the NSwag services
            //services.AddSwaggerDocument();
            //ou
            services.AddSwaggerDocument(o =>
            {
                //Configura Header
                o.PostProcess = document =>
                {
                    document.Info.Title = "Core API";
                    document.Info.Version = "v1";
                    document.Info.Description = "API de RESTful Services for ISI";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "ISI",
                        Email = "isi@ipca.pt",
                        Url = "https://www.ipca.pt"
                    };
                    document.Info.License = new NSwag.OpenApiLicense
                    {
                        Name = "Use under IPCA rights",
                        Url = "https://www.ipca.pt/license"
                    };
                };

                o.DocumentName = "lufer_v1";

                //Adiciona o token "Authorize"
                o.OperationProcessors.Add(new OperationSecurityScopeProcessor("JWT Token"));
                
                o.AddSecurity("JWT Token", Enumerable.Empty<string>(),
                    new NSwag.OpenApiSecurityScheme()
                    {
                        Type = OpenApiSecuritySchemeType.ApiKey,
                        Name = "Authorization",
                        In = OpenApiSecurityApiKeyLocation.Header,
                        Description = "Type into the value field: Bearer {token}"
                    });
            });//AddSwaggerDocument

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            //2º
            // Register the NSwag generator and the Swagger UI middlewares
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseAuthentication();        //para usar "login" e gerar o JWT
            app.UseAuthorization();         //caso interesse controlar autorização...com Roles...não está a ser considerado!

        }
    }
}
