using System.Data.SqlTypes;

namespace ControleVagasEstacionamentoVetor
{
    class Carro
    {

        public string  Dono { get; set; }

        public string Placa { get; set; }


        public Carro(string dono, string placa)
        {
            Dono = dono;
            Placa = placa;

        }

        public override string ToString()
        {
            return Dono + ", " + Placa;
        }


    }
}

