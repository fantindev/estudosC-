namespace Exercicio3GPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos carros vão estacionar? ");
            int vagas = int.Parse(Console.ReadLine());

            Carro[] vect = new Carro[15];


            for (int i = 0; i < vagas; i++)
            {
                Console.Write("Dono do carro: ");
                string dono = Console.ReadLine();
                Console.Write("Placa do carro: ");
                string placa = Console.ReadLine();
                Console.Write("Vaga do clietne: ");
                int vaga = int.Parse(Console.ReadLine());
                vect[vaga] = new Carro(dono, placa);
            }
            Console.WriteLine();

            Console.WriteLine("Vagas ocupadas:");
            for (int i = 0; i < 15; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");
                }

            }
            Console.WriteLine("Vagas Vazias:");
            int vagaLivre = 0;
            for (int i = 0; i < 15; i++)
            {
                

                if (vect[i] == null)
                {
                    vagaLivre++;
                    Console.WriteLine(vagaLivre);
                }
            }
        }
    }
}
