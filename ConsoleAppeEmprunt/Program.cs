using Lefinancier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulateur_emprunt
{
    class Program
    {
        static void Main(string[] args)
        {
            /// tauxInteretAnnuel    ->  taux de l'interet annuel
            /// nbrAnneeRbmt         ->  le nombre d'annee de remboursement
            /// capitalEmprunte      ->  le capital emprunte K
            /// tauxInteretMensuel	->  taux de l'intérêt mensuel<- tauxInteretAnnuel/12
            /// mensualite           ->  la mensualite constante a rembourser
            /// nbMois                 ->  le nombre de mois de la période
            /// interetsMensuel       ->  les intérets du mois courant
            /// amortissementMois    ->  le montant de l'amortissement du capital pour le mois courant
            double tauxInteretAnnuel, tauxInteretMensuel;
            DateTime datelimite;
            double capitalEmprunte;
            double mensualite;
            double nbMois;
            double amortissmentMois;
            double partInteret;
            Console.WriteLine("Jusqu'à quelle date souhaitez-vous payer des remboursements?jj/mm/aaaa");
            string[] dateUtilisateur = (Console.ReadLine()).Split('/');
            //datelimite = DateTime.Parse(Console.ReadLine());
            datelimite = new DateTime(int.Parse(dateUtilisateur[2]), int.Parse(dateUtilisateur[1]), int.Parse(dateUtilisateur[0]));
            DateTime datejour = DateTime.Today;
            TimeSpan dureePret = datelimite - datejour;
            nbMois = Math.Floor(((dureePret.Days) / (double)30.44));
            //"perequation" pour la durée moyenne d'un mois : 30.44  
            Console.WriteLine("Quel montant souhaitez-vous emprunter en euros?");
            capitalEmprunte = double.Parse(Console.ReadLine());
            Console.WriteLine("Quel taux annuel d'emprunt vous proposent les organismes de crédit?");
            tauxInteretMensuel = (Double.Parse(Console.ReadLine())) / 1200;
            //commentaire si la personne met en pourcentage!!
            Console.Write("capital " + capitalEmprunte + " taux  interêt :" + tauxInteretMensuel + " durée nb mois :" + nbMois + "\n");

            mensualite = credit.CalculMensualite(capitalEmprunte, tauxInteretMensuel, nbMois);
            Console.WriteLine(" L'échéance à payer chaque mois sera de {0:#,###.00} euros pour un capital emprunté de {1:#,###.00} ", mensualite, capitalEmprunte);
            credit.AfficherTableau_Amrt(capitalEmprunte, tauxInteretMensuel, nbMois, mensualite);


            Console.ReadKey();
        }
    }
}