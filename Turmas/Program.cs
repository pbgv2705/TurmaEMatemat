using Turmas;
public class Program
{
    public static void Main(string[] args)
    {
        string prova1 = "P1";
        string prova2 = "P2";
        int matr = 0;
        Console.WriteLine("Bem-Vindo ao Módulo de Turmas!");
       
        var nome1 = "Maria";
        var matr1 = 080020;

        var aluno1 = new Aluno(nome1, matr1);

        var nome2 = "Fernando";
        var matr2 = 080022;
        var aluno2 = new Aluno(nome2, matr2);

        Turma t1 = new Turma();

        t1.InserirAluno(aluno1);
        t1.InserirAluno(aluno2);
        t1.InserirAluno(new Aluno("João", 080037, 8.4, 7.3));
        t1.InserirAluno(new Aluno("Rodrigo", 090072, 9, 7));
        t1.InserirAluno(new("Nayara", 090048, 6.7, 8.2 ));
        t1.InserirAluno(new("Antonio", 090053, 7.8, 4.5));
        t1.InserirAluno(new("Luiza", 090057, 6.8, 8.5));
        
        t1.LancarNota(aluno1, 8, prova1);
        t1.LancarNota(aluno1, 7.8, prova2);
        t1.LancarNota(aluno2, 7.5, prova1);
        t1.LancarNota(aluno2, 8, prova2);

        t1.ImprimirDados();

        t1.RemoverAluno(aluno2);
        t1.ImprimirDados();

        Console.WriteLine(t1.ImprimEstadisticas()); 
    }
}