using System;

namespace LabSintaxis4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit, a=0, b=1, aux, sum=0;
            Console.WriteLine("SUMA DE SERIE DE FIBONACCI\nIngrese cantidad de números de la serie a sumar: ");
            limit = Int32.Parse(Console.ReadLine());
            for(int i=0; i<limit; i++) {
                aux = a;
                a = b; 
                b = aux + a; 
                sum+=a;
            }
            Console.WriteLine("La suma es: "+sum);
            Console.ReadKey();
        }
    }
}
