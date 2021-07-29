using System;

namespace TesteImc
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public double Massa {get; set;}
        public double Altura {get; set;}


        public Pessoa(string nome, double massa, double altura)
        {
            Nome = nome;
            Massa = massa;
            Altura = altura;
        }
    }
}