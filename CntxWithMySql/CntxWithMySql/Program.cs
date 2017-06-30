using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CntxWithMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WorldEntities ctx = new WorldEntities())
            {
                
                Country co = (from c in ctx.Countries
                              where c.Name == "Benin"
                              select c).First<Country>();
                City ci = new City() {Name="Rabat",country=co,District="Rabat Zemmour Zaier", Population=2000000,CountryCode=co.Code};
                ctx.Cities.Add(ci);
                ctx.SaveChanges();
                //List<Country> lstConty = (from c in ctx.Countries
                //                          where c.Code.StartsWith("M")
                //                          select c).ToList();
                //foreach (var c in lstConty)
                //{
                //    Console.WriteLine(c.Code + " \t " + c.Name);
                //}
                List<City> lstCities = (from cit in ctx.Cities
                                        where cit.Name.StartsWith("R")
                                        select cit).ToList();

                foreach (var mdina in lstCities)
                {
                    Console.WriteLine(mdina.ID + " " + mdina.Name + " " + mdina.Population + " " + mdina.District + " " + mdina.country.Name);
                }

                Console.WriteLine("fin");
                Console.Read();
            }
            /* try
             {
                 MySqlConnection cnx = new MySqlConnection();
                 cnx.ConnectionString = "server=localhost;port=3306;database=world;uid=root;password=root";
                 cnx.Open();
                 MySqlCommand cmd = new MySqlCommand("select * from country", cnx);

                 MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                 MySqlDataReader dr = cmd.ExecuteReader();
                 List<Country> lstc = new List<Country>();
                 while (dr.Read())
                 {
                     Country c = new Country() { Code = dr.GetString(0), Name = dr.GetString(1) };
                     lstc.Add(c);

                 }
                 List<Country> lco = (from c in lstc
                              where c.Code.StartsWith("A")
                              select c).ToList();
                 foreach (Country c in lco)
                 {
                     Console.WriteLine(c.Code + " \t " + c.Name);//dr["Code"]+" \t "+dr["Name"]);
                 }
                 cnx.Close();
                 Console.Read();
             }
             catch (Exception)
             {

                 throw;
             }*/


        }
    }
}
