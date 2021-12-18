/*
 * by lufer
 * WCF Restfull Service
 * 
 * UriTemplate
 * WebGet - operações de leitura: R
 * WebInvoke - operações não de leitura: C, U,D
 * 
 * Ex:
 * localhost/testservice/GetHotelById/2
 * ou 
 * localhost/testservice/Hotel/2
 * 
 * Ver:
 * https://msdn.microsoft.com/en-us/library/dd203052.aspx
 * http://www.codeproject.com/Articles/105273/Create-RESTful-WCF-Service-API-Step-By-Step-Guide
 * 
 * */
//by lufer
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;

public class HotelServices : IService
{
    static ArrayList hs = new ArrayList();  //Simula BD

    public List<Hotel> AddOneHotel(Hotel h)
    {
        ArrayList hs = new ArrayList();
        //hs.Add(h);
        if (!hs.Contains(h)) hs.Add(h);
        return hs.Cast<Hotel>().ToList();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Hotel> GetHotelsList()
    {
        // Cria uma lista para armazenar os Hoteis
        ArrayList hoteis = new ArrayList();
        // Abre a conexão


        OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["turismoConnectionString"].ConnectionString);
        try
        {
            conn.Open();
            string query = @"select * from hoteis";// where Nome like @nome";
            OleDbCommand cmd = new OleDbCommand(query, conn);

            //Instanciar parâmetros
            //cmd.Parameters.Add("@nome", OleDbType.VarChar).Value = nomeHotel;
            //executa query e guarda num DataReader
            OleDbDataReader dr = cmd.ExecuteReader();

            try
            {
                // Percorre o DataReader
                while (dr.Read())
                {
                    //Declara uma variável para um Hotel
                    Hotel h = new Hotel();
                    // instancia os diferentes campos
                    h.Nome = (string)dr["Nome"];
                    h.Cidade = (string)dr["Cidade"];
                    h.Capacidade = (int)dr["Capacidade"];

                    //insere no arrayList
                    hoteis.Add(h);
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

        //converte em genérico
        List<Hotel> list = hoteis.Cast<Hotel>().ToList();
        return list;

    }


    /// <summary>
    /// return JSON data
    /// </summary>
    /// <returns></returns>
    public List<Hotel> GetHotelsListJson()
    {
        return GetHotelsList();
    }


    public Hotel GetHotelById(string id)
    {
        //implementar
        return null;
    }

    public Hotel GetHotelByIDII(string n, string c)
    {
        //Implementar
        Hotel h = new Hotel(n, c, 4900);
        return h;
    }

    public void AddHotel(Hotel h)
    {
        //implementar
        //INSERT INTO hoteis ( Nome, Cidade, Capacidade )
        //VALUES('HotelViana', 'Cidade  sdf s ds ds-jhghjg-khkkh-', 1200);

        string constr = ConfigurationManager.ConnectionStrings["turismoConnectionString"].ConnectionString;
        OleDbConnection con = new OleDbConnection(constr);
        OleDbCommand cmd = new OleDbCommand("insert into Hoteis (nome, cidade, capacidade) values (@hName,@hCidade,@hCapacidade)", con);
        con.Open();
        cmd.Parameters.AddWithValue("@hName", h.Nome);
        cmd.Parameters.AddWithValue("@hCidade", h.Cidade);
        cmd.Parameters.AddWithValue("@hCapacidade", h.Capacidade);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void UpdateHotel(string hotelName, string capacity)
    {
        //implementar
    }


    public void DeleteHotel(string id)
    {
        //implementar
    }

    public ResponseData Auth(RequestData rData)
    {
        var dat = rData.details.Split('|');
        ResponseData resp = new ResponseData
        {
            Name = dat[0],
            Age = dat[1],
            Exp = dat[2],
            Technology = dat[3]
        };
        return resp;
    }

}
