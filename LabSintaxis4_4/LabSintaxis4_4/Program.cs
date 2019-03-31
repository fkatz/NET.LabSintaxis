using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
