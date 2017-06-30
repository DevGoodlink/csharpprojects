using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.netFirst.Models
{
    public class Clients
    {
        public Clients()
        {

        }
        public List<Client> ListeClients()
        {
            return new List<Client>
            {
                new Client {Age=15,Nom="Ali" },
                new Client {Age=30,Nom="Anouar" },
                new Client {Age=20,Nom="Boutayeb" },
                new Client {Age=19,Nom="Mohamed" },
                new Client {Age=28,Nom="Ismaili" }
            };
        }
    }
}