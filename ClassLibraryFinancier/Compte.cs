using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioBanque
{
        public class Compte
        {
        private long numCli;
        private double solde;
        private string nomCli;
        private double decouvertAutorise;

        public long NumCli                                              //Lecture seule
        {
            get => numCli;
        }

        public string NomCli
        {
            get => nomCli; set => nomCli = value;
        }

        public double Solde
        {
            get => solde; set => solde = value;
        }

        public string GetNomCli()
        {
            return this.nomCli;
        }

        public void SetSolde(double _montant)
        {
            this.solde = _montant;
        }

        // Constructeurs
        public Compte(long _numCli, string _nomCli, double _solde, double _da)
        {
            this.numCli = _numCli;
            this.nomCli = _nomCli;
            this.SetSolde(_solde);
            this.decouvertAutorise = _da;
        }
        //Destructeur
        //methodes

        public double DecouvertAutorise
        {
            get => decouvertAutorise; set => decouvertAutorise = value;
        }


        public void Crediter(double somme)
        {
            solde += somme;

        }

        public bool Crediter(Compte c, double somme)
        {
            if (c.solde >= somme)
            {
                c.solde -= somme;
                solde += somme;
                return true;
            }
            else
                return false;
        }

        public bool Debiter(double somme)
        {
            if (solde >= somme)
            {
                solde -= somme;
                return true;
            }
            else
                return false;
        }

        public bool Debiter(Compte c, double somme)                      //(surcharge des méthodes)
        {
            if (solde >= somme)
            {
                solde -= somme;
                c.solde += somme;
                return true;
            }
            else
                return false;
        }

        /*public void Afficher()
        {
            Console.Out.WriteLine("************************");
            Console.Out.WriteLine("Numéro de Compte: " + numero);
            Console.Out.WriteLine("Solde de compte: " + solde);
            Console.Out.WriteLine("Propriétaire du compte : ");
            proprio.Afficher();
            Console.Out.WriteLine("*************************");
        }

        public static void Nombre_Comptes()
        {
            Console.Out.WriteLine("\n\nLe nombre de comptes crées: " + nombre_comptes);
        }*/
        public override string ToString()
        {
            return base.ToString() + "\n" + "****************************************" + "\n" + "Numéro de Compte: " + numCli + "\n" + "Solde de compte: " + solde + "\n" + "Titulaire :" + nomCli + "\n" + "****************************************";
        }

    }
}
