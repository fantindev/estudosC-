using System;
using SystemGlobalization;

namespace Exercicio_3___Carro_combustivel_e_distancia_percorrida_
{
    class Veiculo
    {

        public string Placa { get; set; }

        public string Modelo { get; set; }

        public double Combustivel { get; set; }

        public  Veiculo(string placa, string modelo)
        {
            Placa = placa;
            Modelo = modelo;
        }

        public  Veiculo(string placa, string modelo, double combustivel): this (placa, modelo)
        {
            Combustivel = combustivel;
        }

        public double Abastecer(double litros)
        {
            Combustivel += litros;
        }

        public double Rodar(double km, double kmPorLitro)
        {
            Combustivel - (kn / kmPorLitro);
        }

        public override ToString()
        {
            return "Placa: "
                + Placa
                + ", Modelo: "
                + Modelo
                + ", Combustivel: "
                + Combustivel.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
