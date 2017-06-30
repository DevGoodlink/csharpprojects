using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace exempleMysql
{
    class Program
    {
        static void Main(string[] args)
        {
           /* using (WorldEntities ctx = new WorldEntities())
            {
                var query = from c in ctx.Countries
                            where c.Name.StartsWith("A")
                            select c;
                var list = query.ToList();
                if(list != null)
                {
                    foreach (var country in list)
                    {
                        Console.WriteLine("Name " + country.Name + " \t " + country.SurfaceArea);
                    }
                }
                Console.Read();
            }*/
            string str = "Server=localhost;Database=world;Uid=root;Pwd=root;";
            using (MySqlConnection cnx = new MySqlConnection())
            {
                try
                {
                    cnx.ConnectionString = str;
                    cnx.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from country", cnx);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    Console.WriteLine("Contry list : ");
                    while (reader.Read())
                    {
                        Console.WriteLine("Code : " + reader.GetString(0) + "\t name: " + reader.GetString(1));
                    }
                    Console.Read();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
            
                }
                cnx.Close();
                Console.Read();
            }
            
        }
    }
}
