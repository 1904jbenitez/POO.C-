using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Le_Point;

namespace Le_Point
{
    
           public class Point
        {
            //attributs...
            private string nom;
            private float axeAbscisseX;
            private float axeOrdonneeY;
            //propriétés...
            public string Nom { get => nom; }
            public float AxeAbscisseX { get => axeAbscisseX; }
            public float AxeOrdonneeY { get => axeOrdonneeY; }
            //constructeur...
            public Point(string _nom, float _axeAbscisseX, float _axeOrdonneeY)
            {
                this.nom = _nom;
                this.axeAbscisseX = _axeAbscisseX;
                this.axeOrdonneeY = _axeOrdonneeY;
            }
            public Point()
            {
                this.nom = " ";
                this.axeAbscisseX = 0;
                this.axeOrdonneeY = 0;

            }
            //méthodes...
            public string IndiquerPosition()
            {
                return ToString();
            }


            public void Deplacer(float _x, float _y)
            {
                this.axeAbscisseX = _x;
                this.axeOrdonneeY = _y;
            }

            public override string ToString()
            {
                return "Le point appelé " + nom + " Abscisse est: " + axeAbscisseX + " Ordonnee est: " + axeOrdonneeY;
            }


            public Point ConstruireSymOrd(string _nom)
            {
                Point f = new Point();
                f.nom = _nom;
                f.axeAbscisseX = (this.axeAbscisseX);
                f.axeOrdonneeY = -(this.axeOrdonneeY);

                return f;
            }


            public Point ConstruireSymAbs(string _nom)
            {
                Point f = new Point();
                f.nom = _nom;
                f.axeAbscisseX = -(this.axeAbscisseX);
                f.axeOrdonneeY = (this.axeOrdonneeY);

                return f;

            }


            public Point ConstruireSymOr(string _nom)
            {
                Point f = new Point();
                f.nom = _nom;
                f.axeAbscisseX = -(this.axeAbscisseX);
                f.axeOrdonneeY = -(this.axeOrdonneeY);

                return f;
            }


            public void PermuterBissec()


            {
                float temp = this.axeAbscisseX;
                this.axeAbscisseX = this.axeOrdonneeY;
                this.axeOrdonneeY = temp;
            }
        }
    }

