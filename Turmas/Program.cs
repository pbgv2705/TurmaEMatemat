using Turmas;

public class Program
{
    public static void Main(string[] args)
    {
        string lancarProva = "";
        Console.WriteLine("Bem-Vindo ao Módulo de Turmas!");
       

        var nome1 = "Maria";
        var matr1 = "Quimica";

        var aluno1 = new Aluno(nome1, matr1);

        var nome2 = "Fernando";
        var matr2 = "Biologia";
        var aluno2 = new Aluno(nome2, matr2);

        Turma t1 = new Turma();
        Turma t2 = new Turma();

        t1.InserirAluno(aluno1);
        t2.InserirAluno(aluno2);
        t1.InserirAluno(new Aluno(nome2, matr2));

        t1.LancarNota(matr, p1);

        //        Console.Write("Deseja inserir um novo aluno? (S/N): ");
        //        string novo = Console.ReadLine();

        //        if (novo == "S" || novo == "s")
        //        {
        //            Console.Write("Favor indicar nome do aluno: ");
        //            string novoAluno = Console.ReadLine();
        //            Console.WriteLine("Favor indicar matrícula: ");
        //            string novaMatric = Console.ReadLine();
        //            // var turma = new Turma(dalunos);

        //            bool inserirNovo = Turma.InserirAluno(aluno1);
        //            if (inserirNovo)
        //                Console.WriteLine("O aluno já existe na turma. Não pode ser adicionado");
        //            else
        //                Console.WriteLine("Aluno inserido na turma com sucesso");
        //        }

        //        Console.Write("Deseja remover um aluno da turma? (S/N): ");
        //        string remover = Console.ReadLine();

        //        if (remover == "S" || remover == "s")
        //        {
        //            Console.Write("Favor indicar nome do aluno: ");
        //            string novoAluno = Console.ReadLine();
        //            //Console.WriteLine("Favor indicar matrícula: ");
        //            //string novaMatric = Console.ReadLine();

        //            bool inserirNovo = Turma.RemoverAluno(aluno1);
        //            if (inserirNovo)
        //                Console.WriteLine("O aluno foi removido com sucesso");
        //            else
        //                Console.WriteLine("Aluno não existe na turma. Não pode ser removido");
        //        }
        //        Console.Write("Deseja lançar notas para o aluno? (S/N: ");
        //        lancarProva = Console.ReadLine();
        //        if (lancarProva == "S" || lancarProva == "s")
        //        {
        //            Console.Write("Favor indicar o nome do aluno: ");
        //            string nome3 = Console.ReadLine();
        //            Console.Write("Favor indicar a matrícula: ");
        //            string matr3 = Console.ReadLine();
        //            Console.Write("Favor indicar Prova 1: ");
        //            double p1 = double.Parse(Console.ReadLine());
        //            Turma.LancarNota(p1);
        //            Console.Write("Favor indicar Prova 2: ");
        //            double p2 = double.Parse(Console.ReadLine());
        //            Turma.LancarNota(p1);
        //        }


        //        Turma.ImprimirDados();




    }
}