using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingConversaoDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1270.50;
            float pi = 3.14f;
            int valor = (int)salario + (int)pi;

            Console.WriteLine("O valor convertido de double para int é:" + valor + ".");

            Console.Write("Pressione uma tecla para terminar.");
            Console.ReadKey();
        }
    }
}
