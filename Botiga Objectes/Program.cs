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

            

            int num = 1;
            switch(num)
            {
                case 1:
                if(cistella.AfegirProducteCistella(producte, 3)==0)
                        Console.WriteLine("No money");
                else if(cistella.AfegirProducteCistella(producte, 3)==-1)
                        Console.WriteLine("No space");

                break;
            }

        }
    }
}
