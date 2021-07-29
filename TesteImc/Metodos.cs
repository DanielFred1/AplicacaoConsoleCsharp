using System;

namespace TesteImc
{
    public class Metodos
    {
        static PessoaRepositorio repositorio = new PessoaRepositorio();
        public static void Cadastrar()
        {
            Console.WriteLine("Insira o nome:");
            string EntradaNome = Console.ReadLine().ToUpper();
            Console.WriteLine("Informe a massa (peso):");
            double.TryParse(Console.ReadLine(), out double EntradaMassa);
            Console.WriteLine("Informe a altura:");
            double.TryParse(Console.ReadLine(), out double EntradaAltura);

            double IndiceImc = EntradaMassa / Math.Pow(EntradaAltura, 2);
            switch (IndiceImc)
            {
                case var n when IndiceImc < 17:
                Console.WriteLine($"O IMC é de: {IndiceImc} | Muito abaixo do peso.");
                break;
                case var n when IndiceImc >= 17 && IndiceImc < 18:
                Console.WriteLine($"O IMC é de: {IndiceImc} | Abaixo do peso.");
                break;
                case var n when IndiceImc >= 18 && IndiceImc < 25:
                Console.WriteLine($"O IMC é de: {IndiceImc} | Peso normal.");
                break;
                case var n when IndiceImc >= 25 && IndiceImc < 30:
                Console.WriteLine($"O IMC é de: {IndiceImc} | Acima do peso.");
                break;
                case var n when IndiceImc >= 30 && IndiceImc < 35:
                Console.WriteLine($"O IMC é de: {IndiceImc} | Obesidade grau I.");
                break;
                case var n when IndiceImc >= 35 && IndiceImc < 40:
                Console.WriteLine($"O IMC é de: {IndiceImc} | Obesidade grau II.");
                break;
                case var n when IndiceImc >= 40:
                Console.WriteLine($"O IMC é de: {IndiceImc} | Obesidade grau III.");
                break;
                default:
                break;
            }

            Pessoa NovaPessoa = new Pessoa(id: repositorio.ProximoId(), nome: EntradaNome, massa: EntradaMassa, altura: EntradaAltura, imc: IndiceImc);
            repositorio.Insere(NovaPessoa);
        }

        public static void Listar()
        {
            Console.WriteLine();
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Não há pessoas cadastradas no sistema...");
                return;
            }
            foreach (var pessoa in lista)
            {
                Console.WriteLine($"ID: {pessoa.RetornaId()} | Nome: {pessoa.RetornaNome()}");
            }

            Console.WriteLine("Informe o ID da pessoa que deseja visualizar: ");
            int indicePessoa = int.Parse(Console.ReadLine());
            var descricao = repositorio.RetornaPorId(indicePessoa);
            Console.WriteLine(descricao);
        }
    }
}