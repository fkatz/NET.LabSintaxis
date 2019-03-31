using System;

namespace LabSintaxis4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números pares del 0 al 100");
            for (int i = 2; i < 100; i += 2) Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
