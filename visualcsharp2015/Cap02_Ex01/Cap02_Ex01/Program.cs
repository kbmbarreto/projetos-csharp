using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOME;

            Console.Write("Coloca seu nome ai mano: ");
            NOME = Console.ReadLine();
            Console.WriteLine("Olá, " + NOME);

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerar, senão, fique ai olhando a telinha preta mesmo... ");
            Console.ReadLine();

        }
    }
}
