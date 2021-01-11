using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string otimo = "Honda Civic", bom = "VW Golf", regular = "VW Gol", ruim = "Peugeot 1.4 'Motor 3JP'";
            int opcao;

            #region Apresentação
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Quer comprar um carro? Escolha uma opção aqui e veja a recomendação!");
            Console.WriteLine();
            Console.WriteLine("Tecle 1, para escolher um ótimo carro.");
            Console.WriteLine();
            Console.WriteLine("Tecle 2, para escolher um bom carro.");
            Console.WriteLine();
            Console.WriteLine("Tecle 3, para escolher um carro regular.");
            Console.WriteLine();
            Console.WriteLine("Tecle 4, para escolher um carro ruim.");
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Entrada

            Console.Write("Digite a opção aqui: ");
            opcao = int.Parse(Console.ReadLine());

            #endregion

            #region Switch
            switch (opcao)
            {
                case 1: Console.WriteLine("Indico comprar um " + otimo + ".");
                    break;
                case 2: Console.WriteLine("Indico comprar um " + bom + ".");
                    break;
                case 3: Console.WriteLine("Indico comprar um " + regular + ".");
                    break;
                case 4: Console.WriteLine("Indico comprar um " + ruim + ".");
                    break;
                default: Console.WriteLine("Opção inválida!");
                    break;
            }
            #endregion

            Console.ReadLine();
        }
    }
}
