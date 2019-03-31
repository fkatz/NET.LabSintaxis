using System;

namespace LabSintaxis4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            string clave;
            do
            {
                intentos++;
                Console.WriteLine("Introduzca Clave");
                clave = Console.ReadLine();
            } while (intentos < 4 && clave != "correcta");
            if (clave == "correcta")
            {
                Console.WriteLine("Clave Correcta");
                Console.ReadKey();
            }
        }
    }
}
