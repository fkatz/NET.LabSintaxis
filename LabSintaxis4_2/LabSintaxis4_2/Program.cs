using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese año");
            int año = Int32.Parse(Console.ReadLine());
            bool esBisiesto = false;
            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0)) esBisiesto = true;
            Console.WriteLine("El año "+año+(esBisiesto?"":" no")+" es bisiesto");
            Console.ReadKey();
        }
    }
}
