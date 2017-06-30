using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.CreditCardValidator;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            creditCard cc = new creditCard() { cn = 152, expiryDate = "08/17", number = "1844985525522", type = "visa" };
            string token = "34a0ef83e85b4fb1f701797e2f86fb";
            CardValidatorwssoap ws = new CardValidatorwssoap();
            bool result = ws.validate(cc, token);
            Console.WriteLine("Résultat de la validation de votre carte est " + result);
            Console.Read();
        }
    }
}
