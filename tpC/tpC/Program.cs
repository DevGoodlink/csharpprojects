using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpC
{
    class Program
    {
        static void Main(string[] args)

        {
            //int[] tab = { 1, 2, 3, 4, 5 };

            //IEnumerable<int> pairs = from number in tab
            //                         where number % 2 == 0
            //                         select number;
            //foreach(int i in pairs)
            //{
            //    Console.WriteLine("" + i);
            //}
            //string[] marques = { "Skoda", "Merecedes", "Fiat", "Renault" };
            //IEnumerable<string> m = from x in marques
            //                        where x.Length > 6
            //                        orderby x
            //                        select x;
            //foreach (string ma in m)
            //{
            //    Console.WriteLine(ma);
            //}

            using (Model ctx = new Model())
            {
                //Employe e = new Employe() { FirstName = "Ali", LastName =  "Salhi", PhoneNumber="066666666", EmailId="ahmednounou@gmail.com" };
                //ctx.employees.Add(e);
                //ctx.SaveChanges();
                List<Employee> employes = (from em in ctx.employees
                                          where em.FirstName.StartsWith("a") || em.FirstName.EndsWith("i")
                                          select em).ToList();
                if (employes == null)
                {
                    Console.WriteLine("Aucun employe qui commence par b et se termine par e");
                }
                else
                {
                    foreach (Employee e in employes)
                    {
                        Console.WriteLine(e.FirstName + " \t " + e.LastName +" \t "+e.PhoneNumber);
                    }
                }
            }
            Console.Read();
        }
    }
}
