using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            using (empEntities3 ctx = new empEntities3())
            {
                //List<emp> elst = (from d in ctx.depts
                //                  where d.Id==2
                //                    select d.emps).ToList().AsQueryable();
                //foreach (emp item in elst)
                //{
                //    Console.WriteLine(item.id + " \t " + item.FirstName);
                //}
                //Console.Read();
            }
        }
    }
}
