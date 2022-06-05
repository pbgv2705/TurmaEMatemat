using System.Text;

namespace Turmas
{
    public class Turma
    {
        private readonly List<Aluno> listAlunos;

        public Turma()
        {
            this.listAlunos = new List<Aluno>();
        }

        public bool ExisteAluno(int matr)
        {
            return listAlunos.Exists(a => a.Matricula == matr);
        }
        public bool InserirAluno(Aluno aluno)
        {
            // Conferir se o aluno já existe na lista
            bool existe;
            existe = ExisteAluno(aluno.Matricula);
            if (!existe)
            {
                listAlunos.Add(aluno);
                Console.WriteLine($" A matrícula {aluno.Matricula} do aluno {aluno.Nome} foi inserida com sucesso");
            }


            return existe;
        }
        public bool RemoverAluno(Aluno aluno)
        {
            bool existe;
            existe = ExisteAluno(aluno.Matricula);
            if (existe)
            {
                listAlunos.Remove(aluno);
                Console.WriteLine();
                Console.WriteLine($"A matrícula {aluno.Matricula} do aluno {aluno.Nome} foi removida com sucesso");
            }
            return existe;
        }
        public string LancarNota(Aluno aluno, double resul_prova, string prova)
        {

            bool existe;
            existe = ExisteAluno(aluno.Matricula);
            Console.WriteLine();
            if (existe)
            {
                if (prova.Equals("P1"))
                {
                    aluno.P1 = resul_prova;
                    Console.WriteLine($"A prova P1 do aluno {aluno.Nome}, matrícula {aluno.Matricula} foi inserida com sucesso ");
                }
                    
                else if (prova.Equals("P2"))
                {
                    aluno.P2 = resul_prova;
                    Console.WriteLine($"A prova P2 do aluno {aluno.Nome}, matrícula {aluno.Matricula} foi inserida com sucesso ");
                }
                    
            }
            return prova.ToString();
        }

        public double CalculaNF(double p1, double p2)
        {
            double NF = (p1 + p2) / 2;
            return NF;
        }
        public void ImprimirDados()
        {
            double maior = 0.0, nFinal = 0.0;
            string alunoMaior = "";
            
            Console.WriteLine();
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("                       Lista da turma ordenada alfabéticamente");
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("{0, -20} {1,8} {2,7} {3,7} {4,7}\n", "NOME", "MATRÍCULA", "PROVA 1", "PROVA 2", "NOTA FINAL");
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine();
            listAlunos.Sort(delegate (Aluno a1, Aluno a2)
            {
                return a1.Nome.CompareTo(a2.Nome);
            });
            listAlunos.ForEach(delegate(Aluno a)
            {
                nFinal = CalculaNF(a.P1, a.P2);
                Console.WriteLine(String.Format("{0, -20} {1,8} {2,7} {3,7} {4,7}", a.Nome, a.Matricula, a.P1, a.P2, nFinal.ToString(("N2"))));
            });
            Console.WriteLine();
            Console.WriteLine("___________________________________________________________________________");
        }

        public string ImprimEstadisticas()
        {
            double mP1 = 0.0, mP2 = 0.0, mNF = 0.0, maiorNF = 0.0, alunoNF = 0.0;
            string maiorAluno = "";
            int n = 0;
            listAlunos.ForEach(delegate (Aluno aluno)
           {
               mP1 += aluno.P1;
               mP2 += aluno.P2;
               alunoNF = CalculaNF(aluno.P1, aluno.P2);
               mNF += alunoNF;
               if (alunoNF > maiorNF)
               {
                   maiorNF = alunoNF;
                   maiorAluno = $"A maior nota final da turma foi: \n  Aluno: " + aluno.Nome + 
                        " \n  matrícula: " + aluno.Matricula + " \n  Prova 1: " + aluno.P1 +
                       "  \n  Prova 2: " + aluno.P2 + " \n  obtendo uma Nota Final: " + maiorNF;
               }
               n++;
           });
            mP1 /= listAlunos.Count;
            mP2 /= listAlunos.Count;
            mNF /= listAlunos.Count;

            Console.WriteLine();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("              Estadísticas da Turma");
            sb.AppendLine();
            sb.AppendLine("Media da Prova 1: " + mP1.ToString(("N2")));
            sb.AppendLine("Media da Prova 2: " + mP2.ToString(("N2")));
            sb.AppendLine("Media  da  Turma: " + mNF.ToString(("N2")));
            sb.AppendLine();
            sb.AppendLine(maiorAluno);
            sb.AppendLine("________________________________________________________________________");
            return sb.ToString();
        }

        
    }
}
