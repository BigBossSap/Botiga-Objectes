using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botiga_Objectes
{
    public class Producte
    {
        public string Nom { get; set; }
        public double Preu { get; set; }
        public double Iva { get; set; }



        public Producte()
            {


                        }
        public Producte(string producte, double preu, double iva)
        {
            Nom = producte;
            Preu = preu;
            Iva = iva;
        }


        public double PreuProducte()
        {
            double preuTotal;

            preuTotal = Preu + (Preu * Iva/100);


            return preuTotal;


        }

        public string LlistarProducte()
        {
            string text = $"Producte: {Nom}, preu sense IVA: {Preu}, preu amb IVA: {PreuProducte()}, IVA aplicat: {Iva}";


            return text;
        }

    }
}
