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
            int resultat = -1;
            
            bool trobat = false;
            int posBuscar = 0;
            

            if (Moneder - producte.PreuProducte() * quantitat >= 0)
            {
                for (int j = 0; j < quantitat && posBuscar < ProductesCistella.Length; j++)
                {
                    bool fi = false;
                    while (posBuscar < ProductesCistella.Length && !fi)
                    {
                        if (ProductesCistella[posBuscar] == null)
                        {
                            ProductesCistella[posBuscar] = producte;
                            NelementsCistella++;
                            resultat = 1;
                            fi = true;
                            
                        }
                        else
                        {
                            posBuscar++;
                            if (posBuscar >= ProductesCistella.Length)
                            {
                                resultat = -1;
                                fi = true;
                            }
                        }
                    }
                }
            }
            else
                resultat = 0;

            Moneder = Math.Round((Moneder - producte.PreuProducte() * quantitat), 2);
            return resultat;


        }

        public double CostTotal()
        {
            double costTotal=0;

            for (int i = 0; i < NelementsCistella; i++) {

                costTotal += ProductesCistella[i].Preu + (ProductesCistella[i].Preu * ProductesCistella[i].Iva/100);
                

                    }


            return costTotal;
        }

        //ToString() : retorna de forma amigable un string amb tots els 
        //    productes.Retorna també el total amb iva inclòs.
        //    Recordar que no es pot fer servir el Console.Write 
        //    dintre de l’objecte, el Console.Write s’ha 
        //        de fer servir des del main().

        public string CistellaText()
        {

            string cistellaText = "";

            for(int i=0; i< NelementsCistella; i++)
            {

                cistellaText += $"Nom: <{ProductesCistella[i].Nom}>  \n";
                cistellaText += $"Preu: {ProductesCistella[i].Preu}€ \n";
                cistellaText += $"Iva:  {ProductesCistella[i].Iva}% \n";


                
            }

            cistellaText += $"Cost Total Iva Inclos: {CostTotal()}";

            return cistellaText;

        }

    }
}
