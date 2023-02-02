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
            string[] opcions = new string[] { "1-Client", "2-Administrador", "3-Prova","4-Zika"};
            menutest menu = new menutest(opcions);

            menu.MostrarMenu();
            int seleccio = menu.seleccio();
            //Console.WriteLine(botiga.BotigaText());
            //Console.WriteLine(botiga.BuscarProducte(mesa)); 

            //Console.WriteLine(taula.LlistarProducte());
            //Console.WriteLine(cadira.LlistarProducte());
            //Console.WriteLine(cadira.LlistarProducte());

            //Console.WriteLine(taula.PreuProducte()); 
          
            
            while (seleccio != 3) {
                switch (seleccio)
                {

                    case 0:
                        string[] opcionsClient = new string[] { "1-afegir producte", "2-titola","3-","4" };
                        menutest menuClient = new menutest(opcionsClient);
                        menuClient.MostrarMenu();
                        int seleccio2 = menuClient.seleccio();
                        while (seleccio2 != 3)
                        {
                            switch (seleccio2)
                            {
                                case 0:

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
                                case 2:
                                    Console.WriteLine(cistella.CistellaText());
                                    Console.ReadLine();
                                    break;

                                
                            }

                            menuClient.MostrarMenu();
                            seleccio2 = menuClient.seleccio();

                        }

                        break;
                    case 2:



                        break;
                }
                menu.MostrarMenu();
                seleccio = menu.seleccio();

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
