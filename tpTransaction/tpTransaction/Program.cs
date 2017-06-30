using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;
            while (continuer)
            {

                Console.WriteLine("Veuillez entrer l'id du compte expéditeur : ");
                int accountId = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Veuillez entrer le montant à débiter");
                int amountToTransfer = Convert.ToInt16(Console.ReadLine());

                using (BankEntities ctx = new BankEntities())
                {
                    using (DbContextTransaction tx = ctx.Database.BeginTransaction())
                    {
                        try
                        {
                            //TransactionScope s = new TransactionScope();
                            ctx.Database.ExecuteSqlCommand("Update CurrentAccount set solde = solde - @amountToDebit where id = @accountId",
                            new SqlParameter("@amountToDebit", amountToTransfer), new SqlParameter("@accountId", accountId));
                            SavingAccount sa = ctx.SavingAccounts.First((SavingAccount s) => s.id == accountId);
                            CurrentAccount ca = ctx.CurrentAccounts.First((CurrentAccount c) => c.id == accountId);
                            if (ca.solde < amountToTransfer) throw new Exception("Solde insuffisant pour effectuer cette transaction, transaction annulée");
                            sa.solde += amountToTransfer;
                            ctx.SaveChanges();
                            tx.Commit();
                            Console.WriteLine("Transaction effectuée avec succés");
                        }
                        catch (Exception e)
                        {
                            tx.Rollback();
                            Console.WriteLine("Erreur : " + e.Message);
                        }

                    }
                    //try
                    //{
                    //    CurrentAccount ca = ctx.CurrentAccounts.First((CurrentAccount c) => c.id == a);
                    //    SavingAccount sa = ctx.SavingAccounts.First((SavingAccount s) => s.id == b);
                    //    if (ca.solde < m) throw new Exception("Solde insuffisant pour effectuer cette transaction");

                    //    ca.solde -= amountToTransfer;
                    //    sa.solde += amountToTransfer;

                    //    ctx.SaveChanges();
                    //    Console.WriteLine("Transaction effectuée avec succés");
                    //}
                    //catch (Exception e)
                    //{

                    //    Console.WriteLine(e.Message);
                    //}
                }
                Console.Write("Voulez vous continuer [y|n]");
                if (Console.ReadLine() == "n") continuer = false;
            }
        }
    }
}
