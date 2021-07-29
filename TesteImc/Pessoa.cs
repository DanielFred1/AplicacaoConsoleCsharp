using System;

namespace TesteImc
{
    public class Pessoa
    {
        public int Id {get; protected set;}
        public string Nome {get; set;}
        public double Massa {get; set;}
        public double Altura {get; set;}
        public double IMC { get; set; }

        public Pessoa(int id, string nome, double massa, double altura, double imc)
        {
            Id = id;
            Nome = nome;
            Massa = massa;
            Altura = altura;
            IMC = imc;
        }

        public override string ToString()
        {
            string InformacaoPessoa = "";
            InformacaoPessoa += "Nome: " + this.Nome + Environment.NewLine;
            InformacaoPessoa += "Massa: " + this.Massa.ToString("F1") + Environment.NewLine;
            InformacaoPessoa += "Altura: " + this.Altura.ToString("F2") + Environment.NewLine;
            InformacaoPessoa += "IMC: " + this.IMC.ToString("F1") + Environment.NewLine;
            return InformacaoPessoa;
        }

        public string RetornaNome()
        {
            return this.Nome;
        }

        public int RetornaId()
        {
            return this.Id;
        }
    }
}