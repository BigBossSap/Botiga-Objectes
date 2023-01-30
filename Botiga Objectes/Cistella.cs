using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botiga_Objectes
{
    class Cistella
    {

        public string Data { get; set; }

        private Producte[] ProductesCistella;

        private int NelementsCistella;

        public double Moneder;


        public Cistella( double diners)
        {
            
            Moneder = diners;
            ProductesCistella = new Producte[20];
            NelementsCistella = 0;

        }

        //       ComprarProducte(Producte producte, int quantitat) : Afegeix un producte
        //       tantes vegades com indiqui quantitat.


        public int AfegirProducteCistella(Producte producte, int quantitat)
        {
            // 0 = no hi ha diners, 1=afegit, -1 No afegit per espai.
            int num = 0;
            
            bool trobat = false;
            int posBuscar = 0;

            if (Moneder - producte.Preu * quantitat >= 0)
            {
                while ((ProductesCistella[posBuscar] != null) || (trobat == false) && (posBuscar < ProductesCistella.Length))
                {
                    if (ProductesCistella[posBuscar] == null)
                    {
                        trobat = true;
                    }

                    else
                        posBuscar++;


                }

                if (trobat)
                {
                    ProductesCistella[posBuscar] = producte;                                    
                    NelementsCistella++;
                }

                if (!trobat)
                    num = -1;

               

            }

            
                
            return num;






        }


    }
}
