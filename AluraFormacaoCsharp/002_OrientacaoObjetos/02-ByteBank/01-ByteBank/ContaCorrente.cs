using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_ByteBank; //puxando um namespace

namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public _01_ByteBank.Cliente titular; //puxando uma classe de outro namespace (neste a)
        public int agencia;
        public int numero;
        public double saldo;

        //Método boleano
        public bool Saque(double valor)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        //Método sem retorno (void)
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        //Método com vários argumentos
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
