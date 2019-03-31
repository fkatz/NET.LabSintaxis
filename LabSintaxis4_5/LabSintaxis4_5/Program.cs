using System;
using System.Collections.Generic;

namespace LabSintaxis4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            Dictionary<int, string> meses = new Dictionary<int, string>();
            meses.Add(1, "enero");
            meses.Add(2, "febrero");
            meses.Add(3, "marzo");
            meses.Add(4, "abril");
            meses.Add(5, "mayo");
            meses.Add(6, "junio");
            meses.Add(7, "julio");
            meses.Add(8, "agosto");
            meses.Add(9, "septiembre");
            meses.Add(10, "octubre");
            meses.Add(11, "noviembre");
            meses.Add(12, "diciembre");
            Console.WriteLine("Ingrese mes:");
            String mes = Console.ReadLine();
            foreach (KeyValuePair<int, string> i in meses)
            {
                if (i.Value == mes.ToLower())
                {
                    Console.WriteLine(mes + " " + i.Key);
                    found = true;
                    break;
                }
            }
            if (!found) Console.WriteLine("El mes ingresado no es valido.");
            Console.ReadKey();
        }
    }
}
