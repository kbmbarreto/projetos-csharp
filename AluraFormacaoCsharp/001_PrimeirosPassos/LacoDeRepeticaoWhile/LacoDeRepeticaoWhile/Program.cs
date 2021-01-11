using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("Imprimindo os números de 0 a 10:");
            Console.WriteLine();

            int contador = 0;
            while(contador <= 10)
            {
                Console.WriteLine(contador);
                contador = contador + 1;
            }

            Console.ReadLine();
        }
    }
}
