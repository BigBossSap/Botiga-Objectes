using System;

namespace Botiga_Objectes
{
    class Program
    {
        static void Main(string[] args)
        {
            Producte producte = new Producte();
            Botiga botiga = new Botiga();
            Cistella cistella = new Cistella(2000);

            producte.CreaProducte("taula", 100, 21);


            Console.WriteLine(producte.LlistarProducte());

            botiga.AfegirProducte(producte);
           





            Console.WriteLine(botiga.AfegirProducte(producte)); 

            cistella.AfegirProducteCistella(botiga.)

        }
    }
}
