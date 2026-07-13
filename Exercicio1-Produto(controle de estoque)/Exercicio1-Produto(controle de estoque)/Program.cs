using Exercicio1_Produto_controle_de_estoque_;
using System;

namespace MeuPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod;

            Console.Write("Codigo do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preco do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Havera estoque inicial(S/N)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'S' || resp == 's')
            {
                Console.Write("Insira o valor de estoque inicial: ");
                int quantidadeEmEstoque = int.Parse(Console.ReadLine());
                prod = new Produto(codigo, nome, preco, quantidadeEmEstoque);
            }
            else
            {
                prod = new Produto(codigo, nome, preco);
            }
            Console.WriteLine();
            Console.WriteLine("Dados do produto: ");
            Console.WriteLine(prod);

            Console.WriteLine();
            Console.Write("Insira uma quantidade para adicionar ao estoque: ");
            int quantia = int.Parse(Console.ReadLine());
            prod.EntradaEstoque(quantia);
            Console.WriteLine("Dados do produto:");
            Console.WriteLine(prod);

            Console.WriteLine();
            Console.Write("Insira uma quantiade para remover do estoque: ");
            quantia = int.Parse(Console.ReadLine());
            if (quantia > prod.QuantidadeEmEstoque)
            {
                Console.WriteLine("Estoque insuficiente, operação cancelada");
            }
            else
            {
                prod.SaidaEstoque(quantia);
                Console.WriteLine("Dados do produto:");
                Console.WriteLine(prod);

            }
        }
    }
}
