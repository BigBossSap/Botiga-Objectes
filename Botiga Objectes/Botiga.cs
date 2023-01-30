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

        public Producte[] ProductesBotiga;

        private int Nelements;



        public Botiga()
        {
            ProductesBotiga = new Producte[10];
            Nelements = 0;


        }

        public bool AfegirProducte(Producte Producte)
        {
            bool afegit = false;
            bool trobat = false;
            int posBuscar=0;
            

            while((ProductesBotiga[posBuscar] != null) || (trobat==false)&& (posBuscar<ProductesBotiga.Length))
            {
                if (ProductesBotiga[posBuscar] == null)
                {
                    trobat = true;
                }

                else
                posBuscar++;


            }

            if (trobat) {
                ProductesBotiga[posBuscar] = Producte;
                afegit = true;
                Nelements++;
            }

          
            return afegit;


        }
    }
}
