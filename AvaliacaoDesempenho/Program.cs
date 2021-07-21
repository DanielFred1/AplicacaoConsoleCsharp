using System;

namespace AvaliacaoDesempenho
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = MenuOpcao();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //ToDo: cadastra aluno
                        Console.WriteLine("Insira o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Insira a nota do aluno:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("A nota deve ser informada em fomato decimal.");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                    case "2":
                        //ToDo: lista alunos cadastrados
                        break;
                    case "3":
                        //ToDo: calcula média geral de notas
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                opcaoUsuario = MenuOpcao();
            };

            Console.WriteLine("================ FIM =================");

        }
        private static string MenuOpcao()
            {
                Console.Clear();
                Console.WriteLine("----------- MENU DE ALUNOS -----------");
                Console.WriteLine("[1] Cadastrar aluno");
                Console.WriteLine("[2] Listar alunos");
                Console.WriteLine("[3] Calcular média geral de notas");
                Console.WriteLine("[X] Sair da aplicação");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine();
                return opcaoUsuario;
            }
    }
}
