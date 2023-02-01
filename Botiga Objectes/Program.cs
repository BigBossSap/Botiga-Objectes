using System;

namespace Botiga_Objectes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Productes, taules:
            
            Producte taula = new Producte("taula", 100, 21);
            Producte cadira = new Producte("cadira", 80, 16);
            Producte mesa = new Producte("mesa", 75, 8);
            Botiga botiga = new Botiga(20);
            Cistella cistella = new Cistella(20000);
            botiga.Nom = "Mercadona";
            botiga.AfegirProducte(taula);
            botiga.AfegirProducte(cadira);
            botiga.AfegirProducte(mesa);

            menutest menu = new menutest();

            menu.MostrarMenu();
            //Console.WriteLine(botiga.BotigaText());
            //Console.WriteLine(botiga.BuscarProducte(mesa)); 

            //Console.WriteLine(taula.LlistarProducte());
            //Console.WriteLine(cadira.LlistarProducte());
            //Console.WriteLine(cadira.LlistarProducte());

            //Console.WriteLine(taula.PreuProducte()); 




            int num = 0;
            int num2 = 0;
            num = Convert.ToInt32(Menu());
            while (num != 3) {
                switch (num)
                {

                    case 1:
                        num2 = Convert.ToInt32(Menu2());
                        while (num2 != 4)
                        {
                            switch (num2)
                            {
                                case 1:

                                    Console.WriteLine("Quin produce vols comprar?");
                                    Console.WriteLine(taula.LlistarProducte());
                                    Console.WriteLine(cadira.LlistarProducte());
                                    Console.WriteLine(mesa.LlistarProducte());
                                    string producteComprar = Console.ReadLine();
                                    Console.WriteLine("Quantitat:");
                                    int quantitat = Convert.ToInt32(Console.ReadLine());
                                    if (botiga.BuscarProducte(producteComprar) != -1)
                                    {
                                        cistella.AfegirProducteCistella(botiga.ProductesBotiga[botiga.BuscarProducte(producteComprar)], quantitat);
                                    }

                                    else
                                    {
                                        Console.WriteLine("Producte no trobat");
                                        Console.ReadLine();
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine(cistella.CistellaText());
                                    Console.ReadLine();
                                    break;
                            }

                            num2 = Convert.ToInt32(Menu2());
                        }

                        break;
                    case 2:



                        break;
                }

                num = Convert.ToInt32(Menu());
            }

            static string Menu()
            {
                Console.Clear();
                string[] menu = {
            ">1. Comprador\n",
            ">2. Administrador\n",
            

            };
                Console.WriteLine(new String('*', Console.WindowWidth));
                Console.WriteLine();
                Console.WriteLine(@"
                ██████╗  ██████╗ ████████╗██╗ ██████╗  █████╗ 
                ██╔══██╗██╔═══██╗╚══██╔══╝██║██╔════╝ ██╔══██╗
                ██████╔╝██║   ██║   ██║   ██║██║  ███╗███████║
                ██╔══██╗██║   ██║   ██║   ██║██║   ██║██╔══██║
                ██████╔╝╚██████╔╝   ██║   ██║╚██████╔╝██║  ██║
                ╚═════╝  ╚═════╝    ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═╝
                                              
");
                foreach (string opcio in menu)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(opcio);

                }
                Console.WriteLine();
                Console.WriteLine(new String('*', Console.WindowWidth));
                Console.Write("Selecciona una opció: ");
                string num = Console.ReadLine();
                return num;
            }

            static string Menu2()
            {
                Console.Clear();
                string[] menu = {
            ">1. Comprar Producte\n",
            ">2. Veure Cost Total\n",
            ">3. Mostrar Recipe\n",
            ">4. Volver\n",



            };
                Console.WriteLine(new String('*', Console.WindowWidth));
                Console.WriteLine();
                Console.WriteLine(@"
                ██████╗  ██████╗ ████████╗██╗ ██████╗  █████╗ 
                ██╔══██╗██╔═══██╗╚══██╔══╝██║██╔════╝ ██╔══██╗
                ██████╔╝██║   ██║   ██║   ██║██║  ███╗███████║
                ██╔══██╗██║   ██║   ██║   ██║██║   ██║██╔══██║
                ██████╔╝╚██████╔╝   ██║   ██║╚██████╔╝██║  ██║
                ╚═════╝  ╚═════╝    ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═╝
                                              
");
                foreach (string opcio in menu)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(opcio);

                }
                Console.WriteLine();
                Console.WriteLine(new String('*', Console.WindowWidth));
                Console.Write("Selecciona una opció: ");
                string num = Console.ReadLine();
                return num;
            }

            //static string Menu3()




            //Console.WriteLine(cistella.CistellaText());
        }
    }
}
