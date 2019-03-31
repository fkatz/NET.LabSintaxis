using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una línea de texto.");
            String inputTexto = Console.ReadLine();
            if (inputTexto.Length > 0)
            {
                Console.WriteLine("Opción 1 - Mayúsculas");
                Console.WriteLine("Opción 2 - Minúsculas");
                Console.WriteLine("Opción 3 - Longitud");
                Console.WriteLine("Ingrese opción:");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine();
                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine(inputTexto.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine(inputTexto.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine(inputTexto.Length);
                }
                else
                {
                    Console.WriteLine("No se ingresó opción válida");
                }
            }
            else
            {
                Console.WriteLine("No se ingresó texto");
            }
            Console.ReadKey();
        }
    }
}
