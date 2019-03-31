using System;

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
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(inputTexto.Length);
                        break;
                    default:
                        Console.WriteLine("No se ingresó opción válida");
                        break;
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
