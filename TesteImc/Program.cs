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
                        Console.WriteLine("-------------------- Índice de Massa Corporal ----------------------");
                        Console.WriteLine();
                        Console.WriteLine("O IMC (Índice de Massa Corporal) é um cálculo universal");
                        Console.WriteLine("adotado pela OMS (Organização Mundial da Saúde) para classificar");
                        Console.WriteLine("padrões de saúde relacionados ao peso, como desnutrição e obesidade,");
                        Console.WriteLine("principalmente em populações.");
                        Console.WriteLine();
                        Console.WriteLine("Tabela de referência para IMC:");
                        Console.WriteLine();
                        Console.WriteLine("16 a 16,9 kg/m² - Muito abaixo do peso");
                        Console.WriteLine("17 a 18,4 kg/m² - Abaixo do peso");
                        Console.WriteLine("18,5 a 24,9 kg/m² - Peso normal");
                        Console.WriteLine("25 a 29,9 kg/m² - Acima do peso");
                        Console.WriteLine("30 a 34,9 kg/m² - Obesidade grau I");
                        Console.WriteLine("35 a 40 kg/m² - Obesidade grau II");
                        Console.WriteLine("maior que 40 kg/m² - Obesidade grau III");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------------");
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
