using System;

namespace TesteImc
{
    public class Pessoa
    {
        public int Id {get; protected set;}
        public string Nome {get; set;}
        public double Massa {get; set;}
        public double Altura {get; set;}


        public Pessoa(string nome, double massa, double altura)
        {
            Nome = nome;
            Massa = massa;
            Altura = altura;
        }

        public override string ToString()
        {
            string InformacaoPessoa = "";
            InformacaoPessoa += "Nome: " + this.Nome + Environment.NewLine;
            InformacaoPessoa += "Massa: " + this.Massa + Environment.NewLine;
            InformacaoPessoa += "Altura: " + this.Altura + Environment.NewLine;
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