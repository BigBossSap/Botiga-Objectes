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



        public Botiga(int num)
        {
            ProductesBotiga = new Producte[num];
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

        public int BuscarProducte(Producte producte)
        {
            int pos = 0;
            int cont = 0;
            for(int i=0; i<Nelements;i++)
            {
                if (ProductesBotiga[i].Nom == producte.Nom)
                    pos = cont;

             cont++;
            }



            return pos;

        }

        //ModificarProducte(Producte producte, String nou_nom, double nou_preu) : Mètode
        //    públic.Donat un producte hem de buscar-lo a la taula de productes per saber
        //    quina posició de la taula ocupa, per així
        //    després modificar les dades. Retorna un booleà amb true si l’ha modificat i false si ho ha pogut.

        public bool ModificarProducte(Producte producte, string nomNou, double nouPreu)
        {
            bool trobat = false;

            int pos = BuscarProducte(producte);



            return trobat;


        }
    }
}
