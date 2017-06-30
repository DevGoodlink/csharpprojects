using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportif
{
    class Program
    {
        static void Main(string[] args)
        {
            using (clubSportEntities1 ctx = new clubSportEntities1())
            {
                athlete a = new athlete() { id = 1, nom = "Guerrouj", prenom = "Hicham", telephone = "06777777", ddn = new DateTime(1977, 1, 1), dateInscription = new DateTime(2000, 1, 2) };
                entraineur e = new entraineur() { id = 2, nom = "Zaki", prenom = "Mohamed", telephone = "111111", ddn = new DateTime(1960, 1, 1), adresse = "Casa", disciplineSportive = "football" };
                assurance ass = new assurance() { id = 1, datedebut = new DateTime(2017, 01, 01), datefin = new DateTime(2018, 12, 31), athlete = a };
                ctx.assurances.Add(ass);
                ctx.membres.Add(a);
                ctx.membres.Add(e);

                //liste des athlètes
                List<athlete> ltAth = (from at in ctx.athletes
                                       where at.dateInscription != null
                                       select at).ToList();
                //liste des entraineurs
                List<entraineur> lstEnt = (from en in ctx.entraineurs
                                       where en.disciplineSportive != null
                                       select en).ToList();

                //liste des athlètes non assurés
                List<athlete> lstAthnonAssu = (from anonass in ctx.athletes
                                               where anonass.assurances == null
                                               select anonass).ToList();
                //suppression de l'athlète
                athlete anonassure = (from an in ctx.athletes
                                      where an.assurances == null
                                      select an).FirstOrDefault();
                ctx.athletes.Remove(anonassure);



                ctx.SaveChanges();


            }
        }
    }
}
