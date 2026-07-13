using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ControleEstoqueProdutoPoo
{
     class Produto
    {

        public int Codigo { get; private set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public int QuantidadeEmEstoque { get; private set; }

        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public Produto(int codigo, string nome, double preco, int quantidadeEmEstoque): this (codigo, nome, preco)
        {
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }


        public void EntradaEstoque(int quantidade)
        {
            QuantidadeEmEstoque += quantidade;
        }

        public void SaidaEstoque(int quantidade) 
        { 
            QuantidadeEmEstoque -= quantidade;
        }

        public override string ToString()
        {
            return "Produto: "
                + Codigo
                + ", Nome: "
                + Nome
                + ", Preco: "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", Estoque: "
                + QuantidadeEmEstoque;

        }

    }

}

