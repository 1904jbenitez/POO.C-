using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassFraction;

namespace ClassFraction
{
    public class Fraction
    {
        int num;                                        //num
        int denom;                                      //denom

        //Propriétés
        public int Numerateur
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        public int Denominateur
        {
            get
            {
                return denom;
            }
            set
            {
                denom = value;
            }
        }
        // Constructeur
        public Fraction(int _numerateur, int _denominateur)
        {
            try
            {
                this.num = _numerateur;
                this.denom = _denominateur;
                double lafraction = (double)this.num / this.denom;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Division par zero impossible" + e.Message);
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }

        }
        public Fraction(int _numerateur)
        {
            this.num = _numerateur;
            this.denom = 1;
        }
        public Fraction()
        {
            this.num = 0;
            this.denom = 1;
        }
        //Méthodes fraction
        public override string ToString()
        {
            string chaineFraction = "";
            if (this.Denominateur == 1)
            {
                chaineFraction += this.Numerateur;
            }
            else
            {
                if (this.denom < 0)
                {
                    if (this.num > 0)
                    {
                        chaineFraction += (-this.num) + "/" + (-this.denom);
                    }
                    else
                    {
                        chaineFraction += (-this.num) + "/" + (-this.denom);
                    }
                }
                else
                {
                    chaineFraction += this.num + "/" + this.denom;
                }
            }
            return chaineFraction;
        }

        public void inverse()
        {
            int temp = num;
            num = denom;
            denom = temp;
        }

        public void oppose()
        {
            Numerateur = (this.num * (-1));
        }

        public bool SuperieurA(Fraction _autreFraction)
        {
            double temp1 = (double)Numerateur / Denominateur;
            double temp2 = (double)_autreFraction.Numerateur / _autreFraction.Denominateur;
            if (temp1 > temp2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Fraction Somme(Fraction _autreFraction)
        {

            int num = (this.num * _autreFraction.denom) + (_autreFraction.num * this.denom);
            int denom = this.Denominateur * _autreFraction.Denominateur;
            Fraction Resultat = new Fraction(num, denom);
            Resultat.reduire();

            return Resultat;
        }

        public Fraction Soustraction(Fraction _autrefraction)
        {

            return (new Fraction(this.num * _autrefraction.denom - _autrefraction.num * this.denom, this.denom * _autrefraction.Denominateur)).reduire2();

        }

        public Fraction Multiplication(Fraction _autrefraction)
        {
            return (new Fraction(this.num * _autrefraction.num, this.denom * _autrefraction.denom)).reduire2();
        }

        // a/b : c/d <=> a/b*d/c
        public Fraction Division(Fraction _autrefraction)
        {
            return (new Fraction(this.num * _autrefraction.denom, this.denom * _autrefraction.num)).reduire2();
        }

        // (a/b)puissance n  ( a puissance n/ b puissance n)
        public Fraction Puissance(double _n)
        {
            return (new Fraction((int)Math.Pow((double)this.num, _n), (int)Math.Pow(Convert.ToDouble(this.denom), _n))).reduire2();
        }

        private Fraction reduire2()
        {
            Fraction _areduire = new Fraction(this.num, this.denom);
            int diviseur = this.GetPGCD();
            _areduire.Numerateur /= diviseur;
            _areduire.Denominateur /= diviseur;

            if (_areduire.num < 0 && _areduire.denom < 0)
            {
                _areduire.Numerateur = -Numerateur;
                _areduire.Denominateur = -Denominateur;

            }

            if (_areduire.num > 0 && _areduire.denom < 0)
            {
                _areduire.Numerateur = -Numerateur;
                _areduire.Denominateur = -Denominateur;
            }
            return _areduire;

        }

        private void reduire()
        {
            int diviseur = this.GetPGCD();
            this.Numerateur /= diviseur;
            this.Denominateur /= diviseur;
            if (this.num < 0 && this.denom < 0)
            {
                this.Numerateur = -Numerateur;
                this.Denominateur = -Denominateur;
            }
            if (this.num > 0 && this.denom < 0)
            {
                this.Numerateur = -Numerateur;
                this.Denominateur = -Denominateur;
            }
        }

        private int GetPGCD()
        {
            int a = this.num;
            int b = this.denom;
            int pgcd = -1;
            if (a == 0) pgcd = b;
            else if (b == 0) pgcd = a;
            else
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                        b -= a;
                    else
                        a -= b;
                }
                pgcd = a;
            }
            return pgcd;
        }
    }
}
