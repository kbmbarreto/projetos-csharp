using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionaisBooleana
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacidade = 44;
            int passageiros;
            decimal total;

            Console.WriteLine("Insira o numero de passageiros ja confirmados para a viagem: ");
            passageiros = int.Parse(Console.ReadLine());

            total = passageiros / capacidade;

            if (total <=1)
            {
                Console.WriteLine("Vai gastar pouco, nem precisa contratar mais que 1 ônibus!");
            }
            else
            {
                if (total <=4)
                {
                    Console.WriteLine("Será necessário contratar " + (int)total + " ônibus.");
                }
                else
                {
                    if (total >= 5)
                    {
                        Console.WriteLine("Prepara po bolso, e não venda fiado, pois terá que contratar " + (int)total + " ônibus para levar esse povo.");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
