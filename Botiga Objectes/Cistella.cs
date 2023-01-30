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

        private Cistella[] ProductesCistella;

        private int NelementsCistella;

        public double Moneder;


        public Cistella( double diners)
        {
            
            Moneder = diners;
            ProductesCistella = new Cistella[20];
            NelementsCistella = 0;

        }

        //       ComprarProducte(Producte producte, int quantitat) : Afegeix un producte
        //       tantes vegades com indiqui quantitat.


        public bool AfegirProducteCistella(Producte producte, int quantitat)
        {

            int i = 0;
            






        }


    }
}
