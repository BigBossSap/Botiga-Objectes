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

        private Producte[] Productes;

        private int Nelements;



        public Botiga()
        {
            Productes = new Producte[10];
            Nelements = 0;


        }

        public bool AfegirProducte(Producte Producte)
        {
            bool afegit = false;
            bool trobat = false;
            int posBuscar=0;
            

            while((Productes[posBuscar] != null) || (trobat==false)&& (posBuscar<Productes.Length))
            {
                if (Productes[posBuscar] == null)
                {
                    trobat = true;
                }

                else
                posBuscar++;


            }

            if (trobat) {
                Productes[posBuscar] = Producte;
                afegit = true;
                Nelements++;
            }

          
            return afegit;


        }
    }
}
