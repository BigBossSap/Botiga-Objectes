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


        public Cistella(string nomBotiga, double diners)
        {
            
            Moneder = diners;
            ProductesCistella = new Cistella[20];
            NelementsCistella = 0;

        }

        
    }
}
