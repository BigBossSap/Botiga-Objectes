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
            int pos = -1;
            int cont = 0;
            for(int i=0; i< ProductesBotiga.Length; i++)
            {
                if(ProductesBotiga[i] == null)
                {
                    cont++;
                }
                else if (ProductesBotiga[i].Nom == producte.Nom)
                {
                    pos = cont;
                    cont++;
                }
                cont++;
            }
          return pos;
        }
        private int BuscarProducte(string producte)
        {
            int pos = -1;
            int cont = 0;
            for (int i = 0; i < ProductesBotiga.Length; i++)
            {
                if (ProductesBotiga[i] == null)
                {
                    cont++;
                }
                else if (ProductesBotiga[i].Nom == producte)
                {
                    pos = cont;
                    cont++;
                }
                cont++;
            }
            return pos;
        }
        public Producte TornarProducte(string nom)
        {
            int cont = 0;
            int pos = 0;
            for (int i = 0; i < ProductesBotiga.Length; i++)
            {
                if (ProductesBotiga[i] == null)
                {
                }
                else if (ProductesBotiga[i].Nom == nom)
                {
                    pos = cont;
                    cont++;
                }
                cont++;
            }
            return ProductesBotiga[pos];
        }
        //ModificarProducte(Producte producte, String nou_nom, double nou_preu) : Mètode
        //    públic.Donat un producte hem de buscar-lo a la taula de productes per saber
        //    quina posició de la taula ocupa, per així
        //    després modificar les dades. Retorna un booleà amb true si l’ha modificat i false si ho ha pogut.
        public bool ModificarProducte(Producte producte, string nomNou, double preuNou, double ivaNou)
        {
            bool trobat = false;
                producte.Nom = nomNou;
                producte.Preu_sense_iva = preuNou;
                producte.Iva = ivaNou;
                trobat = true;
            return trobat;
        }
        //public bool ModificarProducte(string producte, string nomNou, double preuNou)
        //{
        //    bool trobat = false;
        //    if (BuscarProducte(producte) != -1)
        //    {
        //        int pos = BuscarProducte(producte);
        //        ProductesBotiga[pos].Nom = nomNou;
        //        ProductesBotiga[pos].Preu = preuNou;
        //        trobat = true;
        //    }
        //    return trobat;
        //}
        //EsborrarProducte(Producte producte) : Mètode públic.Donat un producte hem de buscar-lo a
        //    la taula de productes per saber quina posició de la taula ocupa, 
        //    per així després esborrar-lo.Per esborrar-lo de la taula, 
        //    posarem null en el lloc de la taula que s’hagi trobat.
        public bool EsborrarProducte(Producte producte)
        {
            bool esborrat = false;
            if (BuscarProducte(producte) != -1)
            {
                int pos = BuscarProducte(producte);
                ProductesBotiga[pos] = null;
                esborrat = true;
                Nelements--;
            }
            return esborrat;
        }
        //PrestatgeLliure() : Mètode privat.Retorna la 
        //    posició de la taula a on es pot afegir un producte. 
        //    Retorna -1 si la botiga està plena.
        public int PrestatgeLLiure()
        {
            int i = 0;
            bool trobat = false;
            int pos = 0;
            while ((i <= ProductesBotiga.Length)&&(!trobat))
            {
                if (ProductesBotiga[i] == null)
                {
                    trobat = true;
                    pos = i;
                }
                else
                    i++;
            }
            return pos;
        }
        //ToString(): retorna de forma amigable un string amb tots els productes amb 
        //    els seus preus i iva respectius. 
        //    Recorda que no es pot fer servir el Console.Write 
        //    dintre de l’objecte, el Console.Write s’ha de fer servir des del main().
        public string BotigaText()
        {
            string botigaText = "";
            for (int i = 0; i < ProductesBotiga.Length; i++)
            {
                if (ProductesBotiga[i] != null)
                {
                    botigaText += new string(' ',Console.WindowWidth/3)+ $"Nom: {ProductesBotiga[i].Nom}\n";
                    botigaText += new string(' ', Console.WindowWidth / 3) + $"Preu: {ProductesBotiga[i].Preu_sense_iva}€ \n";
                    botigaText += new string(' ', Console.WindowWidth / 3) + $"IVA: {ProductesBotiga[i].Iva}%\n";
                }
            }
            return botigaText;
        }
    }
}
