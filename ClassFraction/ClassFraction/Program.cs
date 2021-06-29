using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassFraction
{
    public class Fraction
    {
        int num;                                        //numerateur
        int denom;                                      //denominateur

        // S'ocupper de l'instantiation
        //S'ocupper de l'affichage (les diferents tipes)
        public int Unum { get => num; set => num = value; }
        public int Udenom { get => denom; set => denom = value; }


        public Fraction(int Unum, int Udenom)            //constructeur
        {
            this.num = Unum;
            this.denom = Udenom;
        }

        public Fraction()                               //Constructeur ref.
        {
            this.num = 0;
            this.denom = 1;
        }

        public double Infos(int num, int denom)
        {
            return num / denom;
        }

        public override string ToString()
        {
            return +this.num + "/" + this.denom;
        }

        public void Oppose(int num, int denom)
        {
            this.num = -(num);
        }

        public void Inverse()
        {
            this.num = this.denom;
            this.denom = this.num;

        }

        public bool Superieur(Fraction _F)
        {
            if ((this.num / this.denom) < (_F.num / _F.denom))
            {
                return false;
            }
            else
            {
                Console.WriteLine(this + " est supérieur à " + _F);
                return true;
            }
        }

        public bool Egal(Fraction _F)
        {
            if ((this.num / this.denom) == (_F.num / _F.denom))
            {
                Console.WriteLine(this + " est égal à " + _F);
                return true;
            }
            else
            {
                return false;
            }

        }

        private int Reduire()
        {
            List<int> TAB = new List<int>();

            int numerateur = this.num;
            int denominateur = this.denom;
            int D = 0;

            if (num < 0) { num = -num; }
            if (denom < 0) { denom = -denom; }

            do
            {



                D++;



                if (numerateur % D == 0 && denominateur % D == 0)
                {
                    TAB.Add(D);
                }



            } while (D < numerateur && D < denominateur);

            return TAB.Last();

        }

        public void ToDisplay(Fraction _F)
        {

            Console.WriteLine(this.num / _F.Reduire() + "/" + this.denom / _F.Reduire());



        }


        public void Plus(Fraction _F)
        {
            int NUM;
            int DEN;

            NUM = (this.num * _F.denom) + (_F.num * this.denom);


            DEN = (this.denom * _F.denom);


            Fraction G;
            G = new Fraction(NUM, DEN);


            G.ToDisplay(G);

        }
        public void Moins(Fraction _F)
        {
            int NUM;
            int DEN;

            NUM = (this.num * _F.denom) - (_F.num * this.denom);
            DEN = (this.denom * _F.denom);

            Fraction H;
            H = new Fraction(NUM, DEN);

            H.ToDisplay(H);
        }
        public void Multiplie(Fraction _F)
        {
            int NUM;
            int DEN;


            NUM = (this.num * _F.num);
            DEN = (this.denom * _F.denom);


            Fraction I;
            I = new Fraction(NUM, DEN);


            I.ToDisplay(I);
        }
        public void Divise(Fraction _F)
        {
            int NUM;
            int DEN;

            NUM = (this.num * _F.denom);
            DEN = (this.denom * _F.num);

            Fraction J;
            J = new Fraction(NUM, DEN);

            J.ToDisplay(J);

        }

    }
}
