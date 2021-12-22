using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoCinco
{
    class ContaBancaria
    {
        private int _NumeroConta;
        private string _ClienteBanco1{ get; set;}
        private double _SaldoConta;        

        //PROPRIEDADES CUSTOMIZADAS- GET/SET
        public double SaldoConta
        {
            get
            {
                return _SaldoConta;
            }
            set
            {
                if (_SaldoConta < 0)
                {
                    Console.WriteLine("Não é possível depositar esse valor!");
                    return;
                }
                else
                {
                    _SaldoConta += value;
                }
            }
        } 
        public string ClienteBanco
        {
            get
            {
                return _ClienteBanco1;
            }
            set
            {
                _ClienteBanco1 = value;
            }
        }

        public int NumeroConta
        {
            get
            {
                return _NumeroConta;
            }
            set
            {
                _NumeroConta = value;
            }
        }

        //MÉTODOS(FUNÇÕES)

        public double ChecagemDepositoInicial()
        {
            Console.Write("Haverá depósito inicial (s/n): ");
            char checkLetra = char.Parse(Console.ReadLine());
            if (checkLetra == 's' || checkLetra == 'S' )
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double checkDeposito = double.Parse(Console.ReadLine());
                if (checkDeposito < 0)
                {
                    Console.WriteLine("Não é possível depositar esse valor!");
                }
                else
                {
                    SaldoConta = checkDeposito;
                }
            }
            else
            {
                SaldoConta = 0;
            }

            return SaldoConta;
        }

        public double SacarValor(double valorExterno)
        {
            _SaldoConta -= valorExterno + 5.00;
            return _SaldoConta;
        }

        public override string ToString()
        {
            return           
            "Conta: "
            + NumeroConta
            + ", Titular: "              
            + ClienteBanco
            + ", Saldo: R$"
            + SaldoConta.ToString("F2");
        }
    }
}
