using System;

namespace Botiga_Objectes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Producte taula = new Producte("taula", 100, 21);
            Producte cadira = new Producte("cadira", 80, 16);
            Producte mesa = new Producte("mesa", 75, 8);
            Botiga botiga = new Botiga(20);
            Cistella cistella = new Cistella(20000);

            botiga.AfegirProducte(taula);
            botiga.AfegirProducte(cadira);
            botiga.AfegirProducte(mesa);
            Console.WriteLine(botiga.BotigaText());
            Console.WriteLine(botiga.BuscarProducte(mesa)); 

            Console.WriteLine(taula.LlistarProducte());
            Console.WriteLine(cadira.LlistarProducte());
            Console.WriteLine(cadira.LlistarProducte());

            Console.WriteLine(taula.PreuProducte()); 

            int num = 1;
            switch(num)
            {

                case 1:
                    int result = cistella.AfegirProducteCistella(taula,5);
                if (result==0)
                        Console.WriteLine("No money");
                else if(result==-1)
                        Console.WriteLine("No space");
                else
                        Console.WriteLine("Producte afegit");

                break;
            }

            
            Console.WriteLine(cistella.CistellaText());
        }
    }
}
