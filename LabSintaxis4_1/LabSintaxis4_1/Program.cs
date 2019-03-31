using System;

namespace LabSintaxis4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese otro número: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("El resultado de la suma de " + a + " y " + b + " es " + (a + b) + ".");
            Console.ReadKey();
        }
    }
}
