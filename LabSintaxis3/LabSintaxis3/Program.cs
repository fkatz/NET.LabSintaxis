using System;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] arraicito = new string[cantIteraciones];
            Console.WriteLine("Ingrese "+cantIteraciones+" líneas de texto: ");
            for(int i = 0; i < cantIteraciones; i++)
            {
                arraicito[i] = Console.ReadLine();
            }
            for (int i = cantIteraciones-1; i >=0; i--)
            {
                Console.WriteLine(arraicito[i]);
            }
            Console.ReadKey();
        }
    }
}
