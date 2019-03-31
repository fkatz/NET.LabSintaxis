using System;

namespace LabSintaxis4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese número: ");
            int num = Int32.Parse(Console.ReadLine());
            if (num < 5000 && num > 0)
            {
                Console.WriteLine("En romano: " + ToRoman(num));
            }
            else Console.WriteLine("El número debe estar entre 1 y 4999");
        }
        static string ToRoman(int n)
        {
            string roman = "";
            string[] symbols = { "M", "D", "C", "L", "X", "V", "I" };
            int[] digits = { n / 1000, (n % 1000) / 100, (n % 100) / 10, (n % 10) };
            for (int i = 0; i < digits[0]; i++) roman += symbols[0];
            for (int i = 1; i < 4; i++)
            {
                string u = symbols[i * 2];
                string v = symbols[i * 2 - 1];
                string w = symbols[i * 2 - 2];
                switch (digits[i] % 10)
                {
                    case 1:
                        roman += u;
                        break;
                    case 2:
                        roman += u + u;
                        break;
                    case 3:
                        roman += u + u + u;
                        break;
                    case 4:
                        roman += u + v;
                        break;
                    case 5:
                        roman += v;
                        break;
                    case 6:
                        roman += v + u;
                        break;
                    case 7:
                        roman += v + u + u;
                        break;
                    case 8:
                        roman += v + u + u + u;
                        break;
                    case 9:
                        roman += u + w;
                        break;
                }
            }
            return roman;

        }
    }
}

