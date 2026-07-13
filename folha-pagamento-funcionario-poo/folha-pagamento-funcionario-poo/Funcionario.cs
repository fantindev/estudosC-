using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FolhaPagamentoFuncionarioPoo
{
    class Funcionario
    {
        public int Matricula { get; set; }

        public string Nome { get; set; }

        public double SalarioBase { get; set; }

        public int PercAumento { get; set; }

        public int PercDesc { get; set; }

        public Funcionario(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }


        public Funcionario (int matricula, string nome, double salarioBase): this (matricula, nome)
        {
            SalarioBase = salarioBase;
        }

        public void AumentoSalario(int percAumento)
        {
            SalarioBase += (SalarioBase * percAumento / 100);
        }

        public void DescontoSalarial(int percDesc)
        {
            SalarioBase = SalarioBase - (SalarioBase * percDesc / 100) -50.0 ;
        }

        public override string ToString()
        {
            return "Matricula: "
                + Matricula
                + ", Nome: "
                + Nome
                + ", Salario: "
                + SalarioBase.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}

