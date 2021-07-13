using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux421
{
    public class Partie
    {
        private Lancer manche;
        private int nombreMaxManche;
        private int nombrePoints;
        private int nummanche;
        //constructeur
        public Partie(int _nbmanches)
        {
            this.nombreMaxManche = _nbmanches;
            this.nombrePoints = nombreMaxManche * 10;

        }
        //propriétés
        public Lancer Manche
        {
            get
            {
                return manche;
            }

            set
            {
                manche = value;
            }
        }

        public int Nummanche
        {
            get
            {
                return nummanche;
            }

        }

        public int NombrePoints
        {
            get
            {
                return nombrePoints;
            }

            set
            {
                nombrePoints = value;
            }
        }

        public int NombreMaxManche
        {
            get
            {
                return nombreMaxManche;
            }
        }
        // methodes

        public void MajPoint()
        {
            if (manche.EstGagnant() == true)
            {
                this.NombrePoints += 30;


            }
            else
            {
                this.NombrePoints -= 10;

            }
        }

        public bool EstPerdue()
        {
            if (NombrePoints <= 0)
            {
                return true;

            }
            else
            {

                return false;
            }


        }

        public void NouveauLancer()
        {
            this.nummanche++;
            Manche = new Lancer();

        }



    }
}