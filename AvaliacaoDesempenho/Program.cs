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
                            Console.Clear();
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
                        Console.Clear();
                        if (indiceAluno != 0)
                        {
                            foreach (var a in alunos)
                            {
                                if(!string.IsNullOrEmpty(a.Nome))
                                {
                                    Console.WriteLine($"NOME: {a.Nome.ToUpper()} - NOTA: {a.Nota}");
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há alunos cadastrados no sistema...");
                        }
                        break;

                    case "3":
                        Console.Clear();
                        decimal notaTotal = 0;
                        int totalAlunos = 0;
                            for (var i=0; i<alunos.Length; i++)
                            {
                                if (!string.IsNullOrEmpty(alunos[i].Nome))
                                {
                                    notaTotal = notaTotal + alunos[i].Nota;
                                    totalAlunos++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                        if (totalAlunos != 0)
                        {
                            var mediaGeral = notaTotal / totalAlunos;
                            ConceitoEnum conceitoGeral = new ConceitoEnum();
                            switch (mediaGeral)
                            {
                                case var n when mediaGeral < 4:
                                    conceitoGeral = ConceitoEnum.D;
                                    break;
                                case var n when mediaGeral >= 4 && mediaGeral < 6:
                                    conceitoGeral = ConceitoEnum.C;
                                    break;
                                case var n when mediaGeral >= 6 && mediaGeral < 8:
                                    conceitoGeral = ConceitoEnum.B;
                                    break;
                                case var n when mediaGeral >= 8:
                                    conceitoGeral = ConceitoEnum.A;
                                    break;
                                default:
                                    Console.WriteLine("Erro no conceito");
                                    break;
                            }

                            Console.WriteLine($"MÉDIA GERAL DE NOTAS: {mediaGeral,2} - CONCEITO GERAL: {conceitoGeral}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Não há alunos cadastrados no sistema...");
                        }
                        break;

                    case "4":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                opcaoUsuario = MenuOpcao();
            }

            Console.WriteLine("================ FIM =================");

        }
        private static string MenuOpcao()
            {
                //Console.Clear();
                Console.WriteLine("----------- MENU DE ALUNOS -----------");
                Console.WriteLine("[1] Cadastrar aluno");
                Console.WriteLine("[2] Listar alunos");
                Console.WriteLine("[3] Calcular média geral de notas");
                Console.WriteLine("[4] Limpar console");
                Console.WriteLine("[X] Sair da aplicação");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine();
                return opcaoUsuario;
            }
    }
}
