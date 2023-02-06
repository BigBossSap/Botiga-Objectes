using System;

namespace Botiga_Objectes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WindowHeight = 50;
            Console.WindowWidth = 75;
            
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
            string[] opcions = new string[] { "1-Client", "2-Administrador", "3-Sortir"};
            menutest menu = new menutest(opcions);

            menu.MostrarMenu();
            int seleccio = menu.seleccio();
            //Console.WriteLine(botiga.BotigaText());
            //Console.WriteLine(botiga.BuscarProducte(mesa)); 

            //Console.WriteLine(taula.LlistarProducte());
            //Console.WriteLine(cadira.LlistarProducte());
            //Console.WriteLine(cadira.LlistarProducte());

            //Console.WriteLine(taula.PreuProducte()); 
          
            
            while (seleccio != 2) {
                switch (seleccio)
                {

                    case 0:
                        string[] opcionsClient = new string[] { "1-Afegir producte", "2-Mostrar Cistella","3-Cost Total-Diner restant","4-Enrere" };
                        menutest menuClient = new menutest(opcionsClient);
                        menuClient.MostrarMenu();
                        int seleccio2 = menuClient.seleccio();
                        while (seleccio2 != 3)
                        {
                            switch (seleccio2)
                            {
                                case 0:

                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Productes disponibles: ");
                                    Console.WriteLine(botiga.BotigaText());
                                    Console.WriteLine("Quin produce vols comprar?");
                                    string producteComprar = Console.ReadLine();
                                    
                                    if (botiga.BuscarProducte(producteComprar) != -1)


                                    {
                                        Console.WriteLine("Quantitat:");
                                        int quantitat = Convert.ToInt32(Console.ReadLine());
                                        cistella.AfegirProducteCistella(botiga.ProductesBotiga[botiga.BuscarProducte(producteComprar)], quantitat);

                                        if (cistella.AfegirProducteCistella(botiga.ProductesBotiga[botiga.BuscarProducte(producteComprar)], quantitat)==1)
                                            Console.WriteLine($"Producte {producteComprar} afegit a la cistella {quantitat} veguades");
                                        else if (cistella.AfegirProducteCistella(botiga.ProductesBotiga[botiga.BuscarProducte(producteComprar)], quantitat)==0)
                                            Console.WriteLine("Insuficients diners o espai a la cistella.");

                                        Console.WriteLine("Presiona qualsevol tecla pero continuar.");
                                        Console.ReadLine();

                                    }

                                    

                                    else
                                    {
                                        Console.WriteLine("Producte no trobat");
                                        Console.ReadLine();
                                        Console.WriteLine("Presiona qualsevol tecla pero continuar.");
                                        Console.ReadLine();
                                    }


                                    break;
                                case 1:
                                    
                                    Console.Clear();
                                    Console.WriteLine();
                                    
                                    Console.WriteLine(cistella.CistellaText());
                                    Console.WriteLine();
                                    Console.WriteLine("Presiona qualsevol tecla pero continuar.");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    
                                    Console.WriteLine(cistella.CostTotal());
                                    Console.WriteLine(cistella.Moneder);
                                    Console.WriteLine("Presiona qualsevol tecla pero continuar.");
                                    Console.ReadLine();


                                    break;

                                

                                
                            }

                            menuClient.MostrarMenu();
                            seleccio2 = menuClient.seleccio();

                        }

                        break;

                    case 1:
                        string[] opcionsAdmin = new string[] { "1-Afegir Producte a la Botiga", "2-Mostrar Productes de la Botiga", "3-Modificar Producte", "4-Eliminar Producte", "5-Enrere" };
                        menutest menuAdmin = new menutest(opcionsAdmin);
                        menuAdmin.MostrarMenu();
                        int seleccio3 = menuAdmin.seleccio();

                        while (seleccio3 != 4)
                        {

                            switch (seleccio3)
                            {

                                case 0:
                                    Console.WriteLine("Nom");
                                    string nom = Console.ReadLine();
                                    Console.WriteLine("preu");
                                    double preu = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("iva");
                                    double iva=Convert.ToDouble(Console.ReadLine());

                                    Producte nouProducte=new Producte(nom, preu, iva);
                                    botiga.AfegirProducte(nouProducte);

                                    break;


                                case 1:
                                    
                                    Console.WriteLine();
                                    Console.WriteLine(botiga.BotigaText()); 
                                    Console.WriteLine("Presiona");
                                    Console.ReadKey();


                                    break;

                                case 2:
                                   
                                    Console.WriteLine(botiga.BotigaText());
                                    Console.WriteLine("Quin produce vols modificar?");
                                    string producteModificar = Console.ReadLine();
                                    if (botiga.BuscarProducte(producteModificar) != -1)


                                    {
                                        Console.WriteLine("Nou nom: ");
                                        string nouNom = Console.ReadLine();
                                        Console.WriteLine("Nou Preu:");
                                        int nouPreu = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Nou Iva:");
                                        int nouIva = Convert.ToInt32(Console.ReadLine());
                                        botiga.ModificarProducte(botiga.ProductesBotiga[botiga.BuscarProducte(producteModificar)], nouNom, nouPreu, nouIva);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Producte no trobat");
                                        Console.ReadLine();
                                    }

                                    Console.WriteLine("Presiona");
                                    Console.ReadKey();


                                    break;

                                case 3:


                                    Console.WriteLine(botiga.BotigaText());
                                    Console.WriteLine("Quin produce vols eliminar?");
                                    string producteEliminar = Console.ReadLine();
                                    if (botiga.BuscarProducte(producteEliminar) != -1)


                                    {
                                        
                                        
                                        botiga.EsborrarProducte(botiga.ProductesBotiga[botiga.BuscarProducte(producteEliminar)]);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Producte no trobat");
                                        Console.ReadLine();
                                    }
                                    Console.WriteLine("Presiona");
                                    Console.ReadKey();

                                    break;


                            }


                            menuAdmin.MostrarMenu();
                            seleccio3 = menuAdmin.seleccio();


                        }


                        break;
                   
                }
                menu.MostrarMenu();
                seleccio = menu.seleccio();

            }
            Console.WriteLine("Goodbye");



    

            //static string Menu3()




            //Console.WriteLine(cistella.CistellaText());
        }
    }
}
