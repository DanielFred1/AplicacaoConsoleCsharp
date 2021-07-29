using System;

namespace TesteImc
{
    class Program
    {
        static PessoaRepositorio repositorio = new PessoaRepositorio();
        static void Main(string[] args)
        {
            string OpcaoReposta = OpcaoMenuInicial();
            while (OpcaoReposta.ToUpper() != "X")
            {
                switch (OpcaoReposta)
                {
                    case "1":
                        Metodos.Cadastrar();
                        break;
                    case "2":
                        Metodos.Listar();
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
                OpcaoReposta = OpcaoMenuInicial();
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
            string OpcaoReposta = Console.ReadLine();
            return OpcaoReposta;
        }
    }
}
