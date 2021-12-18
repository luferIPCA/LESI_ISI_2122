/*
 * by lufer
 * 
 * Web Services sobre Bases de Dados com ADO.NET (pag. 141 da Sebenta)
 * Typed DataSets
 * 
 * Receita:
 * 
 * 1- Incluir System.Data e System.Data."Driver"
 * 2- Definir conexão (directa ou externa)
 * 3- Definir Query
 * 4- Executar Query (varia!!!)
 * 5- Tratar resultados
 * 
 * URLS:
 * http://www.connectionstrings.com/
 * https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/connection-strings-and-configuration-files
 * https://www.connectionstrings.com/store-connection-string-in-webconfig/
 * https://blog.elmah.io/the-ultimate-guide-to-connection-strings-in-web-config/
 * ADO.NET
 * http://msdn.microsoft.com/en-us/library/aa302325.aspx
 * */

using System;
using System.Collections;
//using System.Data.SqlClient;  //SQLServer

//conexão "externa"
using System.Configuration;
//NameSpaces necessários:
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Web.Services;

//Segurança

[WebService(Namespace = "http://www.ipca.pt/ISI2021",Description="Serviços para Gerir uma Base de Dados")]
public class GereHoteis : System.Web.Services.WebService
{
    public GereHoteis () {
    }

    #region HOTEIS

    /// <summary>
    /// Devolve um DataSet com todos os Hoteis. Conexão local!
    /// </summary>
    /// <returns></returns>
    [WebMethod(Description="Selecciona todos os Hoteis")]
    public DataSet GetAllHoteis(string cidade)
    {
        DataSet ds= new DataSet();
        OleDbConnection conn = new OleDbConnection();
        
        try
        {

            //1º Passo: Definir conexão (directa)
            //conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=turismo.mdb" ;

            conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["turismoConnectionString"].ConnectionString);

            
            //2ª Passo: Definir query
            string query = "select * from Hoteis where cidade like '" + cidade + "%'";

            //3ª Passo: Preprarar para Executar
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);

            //4º Passo: Executa a query
            da.Fill(ds,"Dados");

            //Devolvo DataSet
            return ds;
        }
        catch (Exception err)
        {
            throw new Exception("ERRO: "+ err.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    /// <summary>
    /// Devolve um DataSet com todos os Hoteis. Conexão local!
    /// </summary>
    /// <returns></returns>
    [WebMethod(Description = "Selecciona todos os Hoteis")]
    public DataSet GetAllHoteisLenta(string cidade, int time)
    {
        //simular delay para testar assincrono...
        System.Threading.Thread.Sleep(time);
        DataSet ds = new DataSet();
        OleDbConnection conn = new OleDbConnection();

        try
        {

            //1º Passo: Definir conexão (directa)
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\temp\turismo.mdb";

            
            //2ª Passo: Definir query
            string query = "select * from Hoteis where cidade like '" + cidade + "%'";

            //3ª Passo: Preprarar para Executar
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
           
            //4º Passo: Executa a query
            da.Fill(ds, "Dados");

            //Devolvo DataSet
            return ds;
        }
        catch (Exception err)
        {
            throw new Exception("ERRO: " + err.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    /// <summary>
    /// Dados sobre um determinado Hotel. Conexão Externa
    /// </summary>
    /// <param name="hotelName"></param>
    /// <returns></returns>
    [WebMethod(Description = "Dados sobre um determinado Hotel")]
    public DataSet getTourismData(string hotelName)
    {
        DataSet ds = new DataSet();

        //conexão externa!
        using (OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["turismoConnectionString"].ConnectionString))
        {
            string query = @"select * from hoteis where (Nome like @nome)";

            //DataAdpater
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);

            //Percorrer um DataSet
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //   
            //}

            //Instanciar parâmetros
            da.SelectCommand.Parameters.Add("@nome", OleDbType.VarChar).Value = hotelName;
            da.Fill(ds, "Hoteis");
            conn.Close();
        }
        return ds;
    }




    /// <summary>
    /// Inserir um Hotel na BD
    /// </summary>
    /// <param name="hotelName"></param>
    /// <param name="cidade"></param>
    /// <returns></returns>
    [WebMethod(Description = "Regista um Hotel")]
    public int InsertTourismData(string hotelName, string cidade)
    {
        int tot = 0;
        //conexão externa
        using (OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["turismoConnectionString"].ConnectionString))
        {
            conn.Open();
            string query = @"insert into hoteis(nome,cidade) values(@nome,@cidade)";
            OleDbCommand cmd = new OleDbCommand(query, conn);

            //Instanciar parâmetros
            cmd.Parameters.Add("@nome", OleDbType.VarChar).Value = hotelName;
            cmd.Parameters.Add("@cidade", OleDbType.VarChar).Value = cidade;

            tot = cmd.ExecuteNonQuery();

            conn.Close();
        }
        return tot;
    }


    /// <summary>
    /// Serializar um conjunto de Hoteis
    /// Utilizar um DataReader
    /// </summary>
    /// <param name="nomeHotel"></param>
    /// <returns></returns>
    [WebMethod(Description = "Toda a informação de Hoteis num array de structs")]
    public Hotel[] GetHoteis(string nomeHotel)
    {
        // Cria uma lista para armazenar os Hoteis
        ArrayList Hoteis = new ArrayList();
        // Abre a conexão


        OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["turismoConnectionString"].ConnectionString);
        try
        {
            conn.Open();
            string query = @"select * from hoteis where Nome like @nome";
            OleDbCommand cmd = new OleDbCommand(query, conn);

            //Instanciar parâmetros
            cmd.Parameters.Add("@nome", OleDbType.VarChar).Value = nomeHotel;
            //executa query e guarda num DataReader
            OleDbDataReader dr = cmd.ExecuteReader();

            try
            {
                // Percorre o DataReader
                while (dr.Read())
                {
                    //Declara uma variável para um Hotel
                    Hotel h;
                    // instancia os diferentes campos
                    h.nome = (string)dr["Nome"];
                    h.cidade = (string)dr["Cidade"];
                    h.capacidade = (int)dr["Capacidade"];

                    //insere no arrayList
                    Hoteis.Add(h);
                }
            }
            finally
            {
                // Fecha o DataReader
                dr.Close();
            }
        }
        finally
        {
            // Fecha a conexão
            conn.Close();
        }
        // Cria um array de Hoteis auxiliar
        Hotel[] res = new Hotel[Hoteis.Count];
        // Copia a lista para array de Hotel
        Hoteis.CopyTo(res);
        return res;
    }


    /// <summary>
    /// Utilizar Typed DataSet
    /// </summary>
    /// <returns></returns>
    [WebMethod(Description = "Toda a informação - via Typed DataSet")]
    public Hoteis getTurismoTypedDataSet()
    {

        OleDbConnection aux = new OleDbConnection();
        aux.ConnectionString = ConfigurationManager.ConnectionStrings["PessoasConnectionString"].ConnectionString;

        //Typed Dataset
        Hoteis ds = new Hoteis();
        
        using (OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["turismoConnectionString"].ConnectionString))
        {
            string query = @"select * from hoteis";

            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);

            da.Fill(ds, ds.Tables[0].TableName);
        }
        return ds;
    }

#endregion

    #region SUMÁRIOS

    
    /// <summary>
    /// Devolve um único valor
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    [WebMethod(Description = "Devolve o nome do Docente", MessageName = "NomeBySigla")]
    public string NomebySigla(string sigla)
    {
        string res = "";
       
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["SumariosConnectionString"].ConnectionString);
        SqlConnection xxx = new SqlConnection();

        

        try
        {
            // Query que só devolve um valor com parâmetro string
            string query = "select nome from professores where sigla_p like @name";
            conn.Open();
            //SqlCommand s = new SqlCommand();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbParameter p = new OleDbParameter();
            //p.ParameterName = "@name";
            //p.Value = sigla;            
            //cmd.Parameters.Add(p);
            //o mesmo que
            cmd.Parameters.Add("@name", OleDbType.VarChar).Value = sigla;
            res = cmd.ExecuteScalar().ToString();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro na BD: " + ex.Message);
        }
        finally
        {
            conn.Close();

        }
        return res;
    }


    /// <summary>
    /// Devolve um valor numérico com ExecuteScalar
    /// </summary>
    /// <returns></returns>
    [WebMethod(Description = "Total com COUNT", MessageName = "Número de Professores")]
    public int Conta()
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["SumariosConnectionString"].ConnectionString);
        OleDbCommand cmd = new OleDbCommand();
        int aux=0;

        try
        {        
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select count(*) from professores";

            object x = cmd.ExecuteScalar();  
        }
        catch (Exception ex)
        {
            throw new Exception("Erro na BD: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
        return aux;
    }


    /// <summary>
    /// Utilização "inadequada" de parâmetros
    /// </summary>
    /// <param name="ProfName"></param>
    /// <returns></returns>
    [WebMethod(Description = "Pesquisa Sumarios com parâmetros 'perigosos'", MessageName = "Sumários por Professor")]
    public DataSet getProfSumarios(string ProfName)
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["SumariosConnectionString"].ConnectionString);
        try
        {
            string query = "select Ano, Semestre, Data, Sigla_p from sumarios where Sigla_p like '" + ProfName + "%'";

            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Sumarios");
            return ds;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro na BD: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    /// <summary>
    /// Insert com DataAdapter
    /// </summary>
    /// <param name="Prof"></param>
    /// <param name="Sala"></param>
    /// <returns></returns>
    [WebMethod()]
    //public int addSumario(string Prof, string Sala, int Num_Sumario, string Sumario, string Disciplina)
    public int addSumario(string Prof, string Sala)
    {
        try
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["SumariosConnectionString"].ConnectionString);
            string query = "insert into sumarios (Sigla_p, Sala) values ('" + Prof + "','" + Sala + "')";
            OleDbCommand command = conn.CreateCommand();
            command.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds, "All");
            return 1;
        }
        catch (Exception e)
        {
            
            throw new Exception("ERRO: " + e.Message);
        }
    }

    /// <summary>
    /// Delete
    /// </summary>
    /// <param name="Prof"></param>
    /// <param name="Sala"></param>
    /// <returns></returns>
    [WebMethod()]
    public int delSumario(string Prof, string Sala)
    {
        try
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["SumariosConnectionString"].ConnectionString);
            string commandString = "DELETE * FROM sumarios WHERE Sigla_p='" + Prof + "' and Sala='" + Sala + "'";
            OleDbCommand command = conn.CreateCommand();
            command.CommandText = commandString;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds, "All");
            return 1;
        }
        catch (Exception e)
        {           
            throw e;         
        }
    }

    /// <summary>
    /// Update
    /// </summary>
    /// <param name="Prof"></param>
    /// <param name="Sala"></param>
    /// <returns></returns>
    [WebMethod()]
    public int updateSumario(string Prof, string Sala)
    {
        try
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["SumariosConnectionString"].ConnectionString);
            string commandString = "update sumarios set Sigla_p='" + Prof + "' where Sala='" + Sala + "';";
            OleDbCommand command = conn.CreateCommand();
            command.CommandText = commandString;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds, "All");
            return 1;
        }
        catch (Exception e)
        {  
            throw e;  
        }
    }

    #endregion

    #region AUTENTICACAO

    /// <summary>
    /// Testar acesso de utilizador
    /// </summary>
    /// <param name="user"></param>
    /// <param name="passwd"></param>
    /// <returns></returns>
    [WebMethod(Description = "Gere Autenticação")]
    public bool UserAccess(string user, string passwd)
    {
        DataSet ds = new DataSet();
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["turismoConnectionString"].ConnectionString);
        string query = "select * from Users where user=@user and passwd=@passwd";
        OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
        //instanciar parâmetros
        da.SelectCommand.Parameters.Add("@user", OleDbType.VarChar).Value = user;
        da.SelectCommand.Parameters.Add("@passwd", OleDbType.VarChar).Value = passwd;
        da.Fill(ds, "Users");

        DataTable dt = ds.Tables[0];
        if (dt.Rows.Count == 0) return false;   //se não surgiram registos da execução da query
        try
        {
            //supostamente só é devolvida uma linha
            DataRow dr = ds.Tables[0].Rows[0];

            //Segurança
            //Utilizar MD5
            //MD5 md5 = new MD5CryptoServiceProvider();
            
            
            if (dr["user"].Equals(user) && (dr["passwd"].Equals(passwd))) 
                return true;
        }
        catch (Exception er)
        {
            throw new Exception("Acesso Negado: " + er.Message);
        }
        return false;
    }
    #endregion

    private void InitializeComponent()
    {

    }
}


/// <summary>
/// Struct para conter a informação de um Hotel
/// </summary>
public struct Hotel
{
    public string nome;
    public string cidade;
    public int capacidade;
}