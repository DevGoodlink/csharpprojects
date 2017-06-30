using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (worldEntities ctx = new worldEntities())
            {
                var query = from c in ctx.countries
                            select c;

                List<country> lstC = query.ToList();
                foreach (country c in lstC)
                {
                    Console.WriteLine(c.Code + " \t " + c.Capital);

                }
                Console.Read();
            }
        }
    }
}
