﻿using System;

namespace Cap03_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMERO;

            Console.Write("Entre com um valor: ");
            NUMERO = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (NUMERO >= 20 && NUMERO <= 90)
                Console.WriteLine("O valor está entre 20 e 90");
            else
                Console.WriteLine("O valor não está entre 20 e 90");

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar: ");
            Console.WriteLine();
        }
    }
}
