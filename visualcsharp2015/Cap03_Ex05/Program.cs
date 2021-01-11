using System;

namespace Cap03_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOME1, NOME2, SEXO1, SEXO2;

            Console.Write("Entre com o 1º nome ..............: ");
            NOME1 = Console.ReadLine();
            Console.Write("Entre o sexo do 1º nome ..........: ");
            SEXO1 = Console.ReadLine();

            Console.Write("Entre com o 2º nome ..............: ");
            NOME2 = Console.ReadLine();
            Console.Write("Entre o sexo do 2º nome ..........: ");
            SEXO2 = Console.ReadLine();

            Console.WriteLine();
            if (SEXO1 == "M" ^ SEXO2 == "M")
                Console.WriteLine(NOME1 + " dança com " + NOME2);
            else
                Console.WriteLine(NOME1 + " DANÇA COM " + NOME2);

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
