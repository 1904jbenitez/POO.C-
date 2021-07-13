using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux421
{
    /// Dérive de la class Random
    public class Alea : Random
    {
        //Attribut
        private static Alea MonAlea = null;
        //Constructeur
        private Alea()
        {
        }
        //Méthodes
        public static Alea GetInstance()
        {
            if (MonAlea == null)
            {
                MonAlea = new Alea();
            }
            return MonAlea;
        }
        // <param name="valMax"></param>
        // <param name="valMin"></param>
        public int Nouveau(int valMin, int valMax)
        {
            return base.Next(valMin, valMax + 1);
        }
        //<param name="valMax"></param>
        public int Nouveau(int valMax)
        {
            return base.Next(valMax + 1);
        }
        public double NouveauReel()
        {
            return base.NextDouble();
        }

    }
}

    