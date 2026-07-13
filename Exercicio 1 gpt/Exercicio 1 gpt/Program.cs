using Exercicio_1_gpt;
using System;

namespace Exercicio_1_gpt
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos assentos serão comprados? ");
            int Acentos = int.Parse(Console.ReadLine());


            Pessoa[] vect = new Pessoa[10];

            
            for(int i = 0; i < Acentos; i++) 
            {
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Idade: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Acento: ");
                int assento = int.Parse(Console.ReadLine());
                vect[assento] = new Pessoa(name, age);
            }

            Console.WriteLine();
            Console.WriteLine("Acentos ocupados:");

            for (int i = 0;i < 10; i++)
            {
                if(vect[i] != null) { 
                Console.WriteLine($"{i}: {vect[i]}");
                 }

            }
        }
    }
}

