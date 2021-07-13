using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCompte;
using ClassLibraryFinancier;

namespace ConsoleAppFinancier
{ 
    public class Program
    {
        static void Main(string[] args)
        {

            //Compte A = new Compte(123456, "Haddock", 15000, -2000);
            //Compte B = new Compte(456789, "Tournesol", 2000, -1000);
            //Console.WriteLine(A);
            //Console.WriteLine("----------------------------");
            //Console.WriteLine(B);

            //bool test = A.Debiter(17000);

            //if (!test)
            //{
            //    Console.WriteLine("debit non autorisé, dépassement de découvert ");


            //}
            //else
            //{
            //    Console.WriteLine("-----------Débit autorisé--------------");
            //    Console.WriteLine(A);

            //}
            //Banque BNP = new Banque("BANQUE NATIONAL PARIS", "MULHOUSE");
            BanqueListe BNP = new BanqueListe("BANQUE NATIONAL PARIS", "MULHOUSE");
            bool ajout;

            ajout = BNP.AjouterCompte("Séraphin", 123456, 3451.10, -5000);

            ajout = BNP.AjouterCompte("Bianca", 123457, 1513.35, -2000);

            ajout = BNP.AjouterCompte("Dupont", 123458, 17348.65, -2000);

            ajout = BNP.AjouterCompte("Haddock", 123459, 13452.50, -2000);

            ajout = BNP.AjouterCompte("Tournesol",123460, 29217.80, -2000);

            if (ajout)
            {
                Console.WriteLine(BNP);

            }
            else
            {
                Console.WriteLine("numero de compte existant, ajout impossible");
            }
            Console.WriteLine("recherche d'un compte: " + BNP.RendCompte(123458));

            Compte max = BNP.CompteSup();

            Console.WriteLine(" Le compte ayant la provision maximum de la banque est : " + BNP.CompteSup());
            string message_erreur = "";
            bool test = BNP.VirementBanque(123460, 145689, 33000, out message_erreur);

            // Console.WriteLine(message_erreur);
            if (!test)
            {
                Console.WriteLine(message_erreur);

            }
            Console.WriteLine(" Le compte ayant la provision maximum de la banque est : " + BNP.CompteSup());



            // Compte max = BNP.CompteSup();
            //  Console.WriteLine(" Le compte ayant la provision maximum de la banque est : " + BNP.CompteSup());

            Console.ReadKey();

        }
    }
}