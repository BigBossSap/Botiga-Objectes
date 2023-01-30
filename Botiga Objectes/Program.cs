using System;

namespace Botiga_Objectes
{
    class Program
    {
        static void Main(string[] args)
        {
            Producte producte = new Producte();
            Botiga botiga = new Botiga();
            Cistella cistella = new Cistella(20000);

            producte.CreaProducte("taula", 100, 21);


            Console.WriteLine(producte.LlistarProducte());

            botiga.AfegirProducte(producte);
           





            
            

            int num = 1;
            switch(num)
            {

                case 1:
                    int result = cistella.AfegirProducteCistella(producte,25);
                if (result==0)
                        Console.WriteLine("No money");
                else if(result==-1)
                        Console.WriteLine("No space");
                else
                        Console.WriteLine("Producte afegit");

                break;
            }

        }
    }
}
