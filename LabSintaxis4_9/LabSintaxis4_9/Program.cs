using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese número de filas: ");
            int n = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string fila = "";
                for (int j = 0; j < n-i-1; j++) fila += " ";
                for (int j = 0; j < (i*2) + 1; j++) fila += "*";
                Console.WriteLine(fila);
            }
            Console.ReadKey();
        }
    }
}
