
using Certidao;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Bem-vindo ao Módulo de Certidão de Nascimento");
        Console.WriteLine("__________________________________________________________________________");
        var nome1 = "Maria Rodriguez";
        var pessoa = new Pessoa(nome1);
        var nome2 = "Felipe Cardoso";
        var pessoa1 = new Pessoa(nome2);

        Console.Write("Deseja Pedir o Certidão de Nascimento? (S/N): ");
        var pedir = Console.ReadLine();
        if (pedir == "S" || pedir == "s")
        {
            var certidao = new CertidaoNascimento(pessoa, DateTime.Now);

        }
        else
        {
            Console.WriteLine("");
        }
    }

}