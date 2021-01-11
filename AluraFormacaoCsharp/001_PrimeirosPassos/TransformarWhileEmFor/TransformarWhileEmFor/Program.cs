using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Código original utilizando While:
 * 
class Programa
{
    static void Main(String[] args)
    {
        int contador = 1;            
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }
    }
}
*
*/

namespace TransformarWhileEmFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }

            Console.ReadLine();
        }
    }
}
