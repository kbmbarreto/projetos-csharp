using System;

namespace Cap03_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int CODIGO;

            Console.Write("Entre com o código de acesso: ");
            CODIGO = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (CODIGO == 1 || CODIGO == 2 || CODIGO == 3)
            {
                if (CODIGO == 1)
                    Console.WriteLine("um");
                if (CODIGO == 2)
                    Console.WriteLine("dois");
                if (CODIGO == 3)
                    Console.WriteLine("três");
            }

            else
                Console.WriteLine("Código inválido");

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
         }
            
    }
}
