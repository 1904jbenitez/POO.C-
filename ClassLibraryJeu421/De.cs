using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux421
{
        public class De
        {

            // Attributs
            private int valeur;
            private Alea hasard;
            //propriétés
            public int Valeur
            {
                get
                {
                    return valeur;
                }

                set
                {
                    valeur = value;
                }
            }
            //Constructeur
            public De()
            {
                this.valeur = 0; //initialisation
            }
            //

            public void jeter()
            {
                //Alea
                hasard = Alea.GetInstance();
                this.valeur = hasard.Next(1, 6);

            }


        }

        

 }


    

