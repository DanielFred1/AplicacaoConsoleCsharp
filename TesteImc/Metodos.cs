using System;

namespace TesteImc
{
    public class Metodos
    {
        static PessoaRepositorio repositorio = new PessoaRepositorio();
        public static void Cadastrar()
        {
            Console.Clear();
            Console.Write("Insira o nome: ");
            string EntradaNome = Console.ReadLine().ToUpper();
            Console.Write("Informe a massa (peso) em [Kg]: ");
            double.TryParse(Console.ReadLine(), out double EntradaMassa);
            Console.Write("Informe a altura em [m]: ");
            double.TryParse(Console.ReadLine(), out double EntradaAltura);

            double IndiceImc = EntradaMassa / Math.Pow(EntradaAltura, 2);

            Pessoa NovaPessoa = new Pessoa(id: repositorio.ProximoId(), nome: EntradaNome, massa: EntradaMassa, altura: EntradaAltura, imc: IndiceImc);
            repositorio.Insere(NovaPessoa);

            Console.WriteLine();
            Console.WriteLine("Usuário cadastrado.");
            Console.WriteLine("----------------------------------------------");

        }

        public static void Listar()
        {
            Console.WriteLine("------------ Listagem de pessoas -------------");
            Console.WriteLine();
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Não há pessoas cadastradas no sistema...");
                Console.WriteLine();
                return;
            }
            foreach (var pessoa in lista)
            {
                Console.WriteLine($"ID: {pessoa.RetornaId()} | Nome: {pessoa.RetornaNome()}");
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.Write("Deseja verificar informação individual? [S/N] ");
            string resposta = Console.ReadLine().ToUpper();
            Console.WriteLine();
            if (resposta == "S")
            {
                Console.Write("Informe o ID da pessoa que deseja visualizar: ");
                int indicePessoa = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------");
                var descricao = repositorio.RetornaPorId(indicePessoa);
                Console.WriteLine(descricao);

                double RecebeImc = descricao.IMC;
                switch (RecebeImc)
                {
                    case var n when RecebeImc < 17:
                        Console.WriteLine("O IMC está abaixo de 17kg/m², muito abaixo do peso.");
                        break;
                    case var n when RecebeImc >= 17 && RecebeImc < 18:
                        Console.WriteLine("O IMC está na faixa de 17kg/m² a 18kg/m², abaixo do peso.");
                        break;
                    case var n when RecebeImc >= 18 && RecebeImc < 25:
                        Console.WriteLine("O IMC está na faixa de 18kg/m² a 25kg/m², peso normal.");
                        break;
                    case var n when RecebeImc >= 25 && RecebeImc < 30:
                        Console.WriteLine("O IMC está na faixa de 25kg/m² a 30kg/m², acima do peso.");
                        break;
                    case var n when RecebeImc >= 30 && RecebeImc < 35:
                        Console.WriteLine("O IMC está na faixa de 30kg/m² a 35kg/m², obesidade grau I.");
                        break;
                    case var n when RecebeImc >= 35 && RecebeImc < 40:
                        Console.WriteLine("O IMC está na faixa de 35kg/m² a 40kg/m², obesidade grau II.");
                        break;
                    case var n when RecebeImc >= 40:
                        Console.WriteLine("O IMC está acima de 40kg/m², obesidade grau III.");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("----------------------------------------------");
            }
            
        }
    }
}