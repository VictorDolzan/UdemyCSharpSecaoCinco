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
        public double PrecoProduto{ get; private set;}
        public int QuantidadeProduto{ get; private set; }

        //CONSTRUTORES
        public Produto(){            
        }
        public Produto(string nome, double preco) : this()
        {
            _nomeProduto = nome;
            PrecoProduto = preco;
        }
        public Produto(string nome, double preco, int quantidade)
        {
            NomeProduto = nome;
            PrecoProduto = preco;
            QuantidadeProduto = quantidade;
        }
        //FIM DOS CONSTRUTORES

        //ENCAPSULAMENTO GET/SET- PROPRIEDADES CUSTOMIZADAS
        public string NomeProduto
        {
            get
            {
                return _nomeProduto;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nomeProduto = value;
                }
            }
        }       
        //FIM DO ENCAPSULAMENTOS- PROPRIEDADES CUSTOMIZADAS

        //FUNÇÕES
        public void AdicionarProdutos(int quantidadeExterna)
        {
            QuantidadeProduto += quantidadeExterna;
        }
        public void RemoverProdutos(int quantidadeExterna)
        {

            if (quantidadeExterna > QuantidadeProduto)
            {
                Console.WriteLine("Valor Inválido!");
                return;
            }
            else
            {
                QuantidadeProduto -= quantidadeExterna;
            }
        }
        public double ValorTotalEmEstoque()
        {
            return PrecoProduto * QuantidadeProduto;
        }

        public override string ToString()
        {
            return _nomeProduto
             + ", R$"
             + PrecoProduto.ToString("F2", CultureInfo.CurrentCulture)
             + ", "
             + QuantidadeProduto
             + " unidades, Total R$"
             + ValorTotalEmEstoque().ToString("F2", CultureInfo.CurrentCulture);
        }

        //FIM DAS FUNÇÕES

    }
}