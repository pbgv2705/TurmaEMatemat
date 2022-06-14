using Progressao;

public class Program
{
    public static void Main(string[] args)
    {
        int inicio = 3;
        int razao = 4;
        int iterac = 10;
        Console.WriteLine();
        Console.WriteLine("__________________________________________________________________"); 
        Console.WriteLine("Bem-vindo ao Módulo de Progressões");

        Console.WriteLine("__________________________________________________________________");
        Console.WriteLine();
        var pa1 = new ProgressAritm(inicio, razao);
        string resul = pa1.PA(inicio, razao, iterac);
        Console.WriteLine(resul);
        Console.WriteLine();
        Console.WriteLine("__________________________________________________________________");
        Console.WriteLine();
        var pg1 = new ProgressGeomet(inicio, razao);
        string resul1 = pg1.PA(inicio, razao, iterac);
        Console.WriteLine(resul1);
        Console.WriteLine();
        Console.WriteLine("__________________________________________________________________");
    }
}

