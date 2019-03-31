using System;

namespace LabSintaxis4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            String s = "";
            Console.WriteLine("Ingrese cantidad: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 3; cant < n; i++)
            {
                if (IsPrimo(i) && IsPrimo(i + 2))
                {
                    s += "{" + i + "," + (i + 2) + "} ";
                    cant++;
                }
            }
            Console.WriteLine("Los primeros " + n + " numeros primos gemelos son:\n" + s);
            Console.ReadLine();
        }
        static bool IsPrimo(int n)
        {
            if (n == 0 || n == 1 || n == 2) return true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}