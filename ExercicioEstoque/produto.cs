using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoCinco
{
    class Produto
    {
        private string _nomeProduto;
        private double _precoProduto;
        private int _quantidadeProduto;

        //CONSTRUTOR
        public Produto(string nome, double preco, int quantidade)
        {
            _nomeProduto = nome;
            _precoProduto = preco;
            _quantidadeProduto = quantidade;
        }


        //private double _quantidadeTotal;
        public string NomeProduto
        {
            get
            {
                return _nomeProduto;
            }
            set
            {
                _nomeProduto = value;
            }
        }
        public double PrecoProduto
        {
            get
            {
                return _precoProduto;
            }
            set
            {
                _precoProduto = value;
            }
        }
        public void AdicionarProdutos(int quantidadeExterna)
        {
            _quantidadeProduto += quantidadeExterna;            
        }
        public void RemoverProdutos(int quantidadeExterna)
        {
            
            if (quantidadeExterna > _quantidadeProduto)
            {
                Console.WriteLine("Valor Inválido!");
                return;
            }
            else
            {
                _quantidadeProduto -= quantidadeExterna;                
            }
        }
        public double ValorTotalEmEstoque()
        {
            return _precoProduto * _quantidadeProduto;
        }

        public override string ToString()
        {
            return _nomeProduto
             + ", R$" 
             + _precoProduto.ToString("F2", CultureInfo.CurrentCulture)
             + ", "
             + _quantidadeProduto
             + " unidades, Total R$"
             + ValorTotalEmEstoque().ToString("F2", CultureInfo.CurrentCulture);
        }

    }
}