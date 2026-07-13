namespace Exercicio2GPT
{
    class Produto
    {

        public string Name { get; set; }

        public double Value { get; set; }


        public Produto(string name, double value)
        {
            Name = name;
            Value = value;
        }


        public override string ToString()
        {
            return Name + ", R$" + Value;


        }
    }
}
