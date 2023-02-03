using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Botiga_Objectes
{
    class menutest



    {

        string[] opciones;
        int opcionSeleccionada = 0;

        public menutest(string[] opciones)
        {
            this.opciones = opciones;




        }

        public void MostrarMenu()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;




            while (true)
            {
                Console.Clear();

                Console.WriteLine(@"
                ██████╗  ██████╗ ████████╗██╗ ██████╗  █████╗ 
                ██╔══██╗██╔═══██╗╚══██╔══╝██║██╔════╝ ██╔══██╗
                ██████╔╝██║   ██║   ██║   ██║██║  ███╗███████║
                ██╔══██╗██║   ██║   ██║   ██║██║   ██║██╔══██║
                ██████╔╝╚██████╔╝   ██║   ██║╚██████╔╝██║  ██║
                ╚═════╝  ╚═════╝    ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═╝
                                              
");

                for (int i = 0; i < opciones.Length; i++)
                {

                    if (i == opcionSeleccionada)
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("* " + opciones[i]);
                       

                    }
                    else
                    {

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("  " + opciones[i]);
                        
                    }
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                }

                ConsoleKeyInfo entrada = Console.ReadKey();

                if (entrada.Key == ConsoleKey.UpArrow)
                {
                    if (opcionSeleccionada > 0)
                    {
                        opcionSeleccionada--;
                    }

                    else if (opcionSeleccionada == 0)
                    {
                        opcionSeleccionada = opciones.Length - 1;
                    }
                }
                else if (entrada.Key == ConsoleKey.DownArrow)
                {
                    if (opcionSeleccionada < opciones.Length - 1)
                    {
                        opcionSeleccionada++;
                    }

                    else if (opcionSeleccionada == opciones.Length - 1)
                    {
                        opcionSeleccionada = 0;
                    }
                }
                else if (entrada.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("\nOpción seleccionada: " + opciones[opcionSeleccionada]);
                    break;
                }
            }
        }


        public int seleccio()
        {
            int seleccio = opcionSeleccionada;


            return seleccio;

        }

        public string FormatMenu(string text)
        {
            text = new string(' ', 23) + text;
            return text;
        }

    }
}
