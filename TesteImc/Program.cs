using System;

namespace TesteImc
{
    class Program
    {
        static PessoaRepositorio repositorio = new PessoaRepositorio();
        static void Main(string[] args)
        {
            string OpcaoReposta1 = OpcaoMenuInicial();
            while (OpcaoReposta1.ToUpper() != "X")
            {
                switch (OpcaoReposta1)
                {
                    case "1":
                        Console.WriteLine("Insira o nome:");
                        string EntradaNome = Console.ReadLine();
                        Console.WriteLine("Informe a massa (peso):");
                        double.TryParse(Console.ReadLine(), out double EntradaMassa);
                        Console.WriteLine("Informe a altura:");
                        double.TryParse(Console.ReadLine(), out double EntradaAltura);

                        Pessoa NovaPessoa = new Pessoa(nome: EntradaNome, massa: EntradaMassa, altura: EntradaAltura);
                        repositorio.Insere(NovaPessoa);
                        break;
                    case "2":
                        Console.WriteLine();
                        var lista = repositorio.Lista();
                        if (lista.Count != 0)
                        {
                            foreach (var pessoa in lista)
                            {
                                Console.WriteLine($"ID: {pessoa.RetornaId()} | Nome: {pessoa.RetornaNome()}");
                            }
                            // Console.WriteLine();
                            // Console.WriteLine("Não há pessoas cadastradas no sistema...");
                            // break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Não há pessoas cadastradas no sistema...");
                            //break;
                            // foreach (var pessoa in lista)
                            // {
                            //     Console.WriteLine($"ID: {pessoa.RetornaId()} | Nome: {pessoa.RetornaNome()}");
                            // }
                        }
                        break;
                    case "3":
                    // Tabela IMC
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção selecionada não foi reconhecida.");
                        break;
                }
                OpcaoReposta1 = OpcaoMenuInicial();
            }
        }

        static string OpcaoMenuInicial()
        {
            Console.WriteLine("=============== CÁLCULO DE IMC ===============");
            Console.WriteLine("[1] Cadastrar nova pessoa para analisar");
            Console.WriteLine("[2] Listar pessoas cadastradas");
            Console.WriteLine("[3] Verificar informações sobre IMC");
            Console.WriteLine("[4] Limpar console");
            Console.WriteLine("[X] Sair do sistema");
            Console.WriteLine("----------------------------------------------");
            string OpcaoReposta1 = Console.ReadLine();
            return OpcaoReposta1;
        }
        static string OpcaoMenuSecundario()
        {
            Console.WriteLine("------------- operação concluída -------------");
            Console.WriteLine("[1] Repetir operação");
            Console.WriteLine("[X] Retornar para o menu anterior");
            Console.WriteLine("----------------------------------------------");
            string OpcaoReposta2 = Console.ReadLine();
            return OpcaoReposta2;
        }  
    }
}
