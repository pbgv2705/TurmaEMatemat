namespace Turmas
{
    public class Turma
    {
        private readonly List<Aluno> listAlunos;
        // 

        public Turma()
        {
            this.listAlunos = new List<Aluno>();
        }

        public bool ExisteAluno(Aluno aluno)
        {
            return listAlunos.Contains(aluno);
        }
        public  bool InserirAluno(Aluno aluno)
        {
            // Verificar si ya existe en la lista
            bool existe;
            existe = ExisteAluno(aluno);
            if (!existe)
                listAlunos.Add(aluno);
            return existe;
        }
        public bool RemoverAluno(Aluno aluno)
        {
            bool existe;
            existe = ExisteAluno(aluno);
            if (existe)
                listAlunos.Remove(aluno);
            return existe;

        }
        public string LancarNota(matr, double prova)
        {
            // Achar aluno na turma

            aluno.prova = prova;

            return prova.ToString();
        }

        public double  CalculaNF(double p1, double p2)
        {
            double NF = (p1 + p2) / 2;
            return NF;
        }
        public void ImprimirDados()
        {
            double maior = 0.0;
            string alunoMaior = "";
            Console.WriteLine();
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine("                             DADOS DA TURMA                                    ");
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine(" Aluno     Matricula          Prova1          Prova2            Nota Final     ");
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine();
            foreach (Aluno aluno in listAlunos)
            {
                double nFinal = CalculaNF(aluno.P1, aluno.P2); // só reconhece aluno.p pelo throw exception
                Console.WriteLine(aluno.Nome + "       " + aluno.Matricula + "          " +
                    aluno.P1 + "     " + aluno.P2 + "       " + nFinal);
                if (maior < nFinal)
                {
                    maior = nFinal;
                    alunoMaior = aluno.Nome + aluno.Matricula + aluno.P1 + aluno.P2;
                }
            }

        }

        private  double CalculaMedia(double p1, double p2)
        {
            double mP1 = 0.0, mP2 = 0.0, mNF = 0.0, maiorNF = 0.0;
            string maiorAluno = "";
            for (int i = 0; i < listAlunos.Count; i++)
            {
                mP1 += listAlunos.P1;
                mP2 += listAlunos.p2;
              //  mNF += 
            }
        }

        public  void ImprimEstadisticas()
        {
            foreach (var item in listAlunos)
            {

            }

        }
    }
}
