using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botiga_Objectes
{
    class menutest
    {

        public void MostrarMenu()
        {


            string[] opciones = new string[] { ">1. Comprador\n",
            ">2. Administrador\n"};
            int opcionSeleccionada = 0;

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
                        Console.WriteLine("* " + opciones[i]);
                    }
                    else
                    {
                        Console.WriteLine("  " + opciones[i]);
                    }
                }

                ConsoleKeyInfo entrada = Console.ReadKey();

                if (entrada.Key == ConsoleKey.UpArrow)
                {
                    if (opcionSeleccionada > 0)
                    {
                        opcionSeleccionada--;
                    }
                }
                else if (entrada.Key == ConsoleKey.DownArrow)
                {
                    if (opcionSeleccionada < opciones.Length - 1)
                    {
                        opcionSeleccionada++;
                    }
                }
                else if (entrada.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("\nOpción seleccionada: " + opciones[opcionSeleccionada]);
                    break;
                }
            }
        }
    }
}
