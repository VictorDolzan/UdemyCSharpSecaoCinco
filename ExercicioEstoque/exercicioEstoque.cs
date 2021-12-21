using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoCinco
{
    class ExercicioEstoque
    {
        public static void ExecutarExercicioEstoque()
        {    

           Console.WriteLine("Entre com os dados do produto: ");
           Console.Write("Nome: ");
           string nomeProd = Console.ReadLine();
           Console.Write($"Digite o preço do Produto: ");
           double precoProd = double.Parse(Console.ReadLine());
           Console.Write($"Quantidade no estoque: ");
           int quantidadeProd = int.Parse(Console.ReadLine());

           Produto prod1 = new Produto(nomeProd, precoProd, quantidadeProd);

           Console.WriteLine("Dados do produto: " + prod1); 
           
           Console.WriteLine();
           Console.Write($"Digite quantos produtos do {prod1.NomeProduto} serão adicionados ao estoque: ");
           prod1.AdicionarProdutos(int.Parse(Console.ReadLine()));
           Console.WriteLine("Dados Atualizados: "+ prod1);

           Console.WriteLine();
           Console.Write($"Digite quantos produtos do {prod1.NomeProduto} serão removidos do estoque: ");
           prod1.RemoverProdutos(int.Parse(Console.ReadLine()));
           Console.WriteLine("Dados Atualizados: "+ prod1);
            

        
        }
    }
}