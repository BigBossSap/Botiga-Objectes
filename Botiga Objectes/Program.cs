using System;

namespace Botiga_Objectes
{
    class Program
    {
        static void Main(string[] args)
        {
            Producte producte = new Producte();
            Botiga botiga = new Botiga();

            producte.CreaProducte("taula", 100, 21);


            Console.WriteLine(producte.LlistarProducte());

            botiga.AfegirProducte(producte);
           





            Console.WriteLine(botiga.AfegirProducte(producte)); 



        }
    }
}
