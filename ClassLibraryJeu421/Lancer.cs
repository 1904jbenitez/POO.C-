using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux421
{
    public class Lancer
    {

        //Attribut 
        private De[] LesTroisDes = new De[3];
        //Constructeur

        public Lancer()
        {
            for (int i = 0; i < LesTroisDes.Length; i++)
            {
                LesTroisDes[i] = new De();
                LesTroisDes[i].jeter();

            }
            Array.Sort(LesTroisDes);

        }
        private void Trier()
        {

            Array.Sort(LesTroisDes);

        }

        public bool EstGagnant()
        {
            bool resultat = false;

            if (LesTroisDes[0].Valeur == 4 && LesTroisDes[1].Valeur == 2 && LesTroisDes[2].Valeur == 1)
            {
                resultat = true;
            }

            return resultat;

        }

        public void ReLancerUnDe(int _numDe)
        {
            LesTroisDes[_numDe - 1].jeter();
            Trier();

        }
        public int GetValeurDe(int _numDe)
        {
            return LesTroisDes[_numDe - 1].Valeur;
        }

    }

}