using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botiga_Objectes
{
    class Botiga
    {


        public string Nom { get; set; }

        private Producte[] ProductesCistella;

        private int Nelements;



        public Botiga()
        {
            ProductesCistella = new Producte[10];
            Nelements = 0;


        }

        public bool AfegirProducte(Producte Producte)
        {
            bool afegit = false;
            bool trobat = false;
            int posBuscar=0;
            

            while((ProductesCistella[posBuscar] != null) || (trobat==false)&& (posBuscar<ProductesCistella.Length))
            {
                if (ProductesCistella[posBuscar] == null)
                {
                    trobat = true;
                }

                else
                posBuscar++;


            }

            if (trobat) {
                ProductesCistella[posBuscar] = Producte;
                afegit = true;
                Nelements++;
            }

          
            return afegit;


        }
    }
}
