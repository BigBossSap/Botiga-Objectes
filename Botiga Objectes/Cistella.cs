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
            int num = -1;
            
            bool trobat = false;
            int posBuscar = 0;

            for (int j=0; j < quantitat && posBuscar < ProductesCistella.Length; j++)
            {
                if (Moneder - producte.PreuProducte() * quantitat >= 0)
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
                        num = 1;
                    }





                }

                else
                    num = 0;

               

            }
                
            return num;






        }

        public double CostTotal()
        {
            double costTotal=0;

            for (int i = 0; i < NelementsCistella; i++) {

                costTotal += ProductesCistella[i].Preu;

                    }


            return costTotal;
        }


    }
}
