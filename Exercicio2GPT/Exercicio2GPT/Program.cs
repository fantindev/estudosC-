using System.Globalization;

namespace Exercicio2GPT
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos produtos a serem adicionados?");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[10];


            for (int i = 0;i < n; i++)
            {
                Console.Write("Nome do produto: ");
                string Name = Console.ReadLine();
                Console.Write("Valor do produto: ");
                double Value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Numero da prateleira: ");
                int Prateleira = int.Parse(Console.ReadLine());
                vect[Prateleira] = new Produto(Name, Value);
            }

            Console.WriteLine();
            Console.WriteLine("Prateleiras ocupadas:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");

                }

            }
        }
    }
}
