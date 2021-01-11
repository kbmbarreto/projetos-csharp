using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //new ContaCorrente(); -- com este comando, podemos criar um objeto a partir da classe.

            //Conta da Gabriela
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.saldo = 100;
            contaGabriela.titular = "Gabs";

            //Conta do Bruno
            ContaCorrente contaBruno = new ContaCorrente();
            contaBruno.saldo = 100;
            contaBruno.titular = "Bruno";

            //Saque na conta da Gabriela
            //contaGabriela.Saque(50);

            //Console.WriteLine("Saldo após o saque: " + contaGabriela.saldo + ".");
            //Console.WriteLine();

            //Deposito na conta da Gabriela
            //contaGabriela.Depositar(25);

            //Console.WriteLine("Saldo após o depósito:" + contaGabriela.saldo + ".");
            //Console.WriteLine();

            //Transferencia entre as contas
            bool resultadoTransferencia = contaBruno.Transferir(5, contaGabriela);

            Console.WriteLine("Saldo da "+contaGabriela.titular+" após o depósito:" + contaGabriela.saldo + ".");
            Console.WriteLine();
            Console.WriteLine("Saldo do "+contaBruno.titular+" após o depósito:" + contaBruno.saldo + ".");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
