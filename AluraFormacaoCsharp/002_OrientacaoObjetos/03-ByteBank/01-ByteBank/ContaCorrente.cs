using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; } //digitando prop TAB TAB ele insere sozinho (Code Sniped)

        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        /* Códigos~inutilizados, pelo código mais atual acima (sobre Get e Set)
         * 
         * public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            else
            {
                this.saldo = saldo;
            }
        }
        */

        //Método boleano
        public bool Saque(double valor)
        {
            if(_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        //Método sem retorno (void)
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        //Método com vários argumentos
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
