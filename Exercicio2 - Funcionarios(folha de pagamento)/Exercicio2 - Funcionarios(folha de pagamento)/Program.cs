using Exercicio2___Funcionarios_folha_de_pagamento_;
using System;

namespace MeuPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func;


            Console.Write("Entre a matricula do funcionario: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("Entre o nome do funcionario: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá salario inicial(S/N)? ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 'S' || resp == 's') 
            {
                Console.Write("Entre o salario base:");
                double salario = double.Parse(Console.ReadLine());
                func = new Funcionario(matricula, nome, salario);
            }
            else
            {
                func = new Funcionario(matricula,nome);
                Console.Write("ERRO! Sem salario inicial nao conseguimos fazer o calculo de aumento e desconto, verifique a informação");
                return;
            }

            Console.WriteLine("Dados do funcionario ");
            Console.WriteLine(func);

            Console.Write("Entre o percentual de aumento: ");
            int PercAumento = int.Parse(Console.ReadLine());
            func.AumentoSalario(PercAumento);
            Console.WriteLine("Dados do funcionario atualizado: ");
            Console.WriteLine(func);

            Console.Write("Entre o percentual para desconto: ");
            int PercDesc = int.Parse(Console.ReadLine());
            func.DescontoSalarial(PercDesc);
            Console.WriteLine("Dados do funcionario atualizado: ");
            Console.WriteLine(func);


        }

    }
 
}
