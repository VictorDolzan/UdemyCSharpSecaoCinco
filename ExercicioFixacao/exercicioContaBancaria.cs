using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoCinco
{
    class ExercicioContaBancaria
    {
        public static void ExecutarExercicioContaBancaria()
        {
            ContaBancaria cont1 = new ContaBancaria();
            
            Console.Write("Entre o número da conta: ");
            cont1.NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            cont1.ClienteBanco = Console.ReadLine();

            cont1.ChecagemDepositoInicial();
            Console.WriteLine("Dados da Conta: " + cont1);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            cont1.DepositarValor(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: " + cont1);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            cont1.SacarValor(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: " + cont1);         
           
        }
    }
}