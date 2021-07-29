using System;

namespace TesteImc
{
    class Program
    {
        static void Main(string[] args)
        {
            string OpcaoReposta1 = OpcaoMenuInicial();
            while (OpcaoReposta1.ToUpper() != "X")
            {
                switch (OpcaoReposta1)
                {
                    case "1":
                    // cadastrar pessoa
                        break;
                    case "2":
                    // listar pessoa
                        break;
                    case "3":
                    // Tablea IMC
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção selecionada não foi reconhecida.");
                        break;
                }
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
            Console.WriteLine("[2] Retornar para o menu anterior");
            Console.WriteLine("----------------------------------------------");
            string OpcaoReposta2 = Console.ReadLine();
            return OpcaoReposta2;
        }
    }
}
