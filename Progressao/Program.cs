using Progressao;

public class Program
{
    public static void Main(string[] args)
    {
        int inicio = 3;
        int razao = 4;
        int iterac = 10;
        int posic = 5;
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
        string resul1 = pg1.PG(inicio, razao, iterac);
        Console.WriteLine(resul1);
        Console.WriteLine();
        Console.WriteLine("__________________________________________________________________");
        // bool reinicia1 = pa1.Reinicializar(inicio);

        pa1.Reinicializar("PA", iterac);

        var termo1 = pa1.TermoAt(posic);
        Console.WriteLine($"O termo da P.A. na posição {posic} é: " + termo1);
        Console.WriteLine();

        pg1.Reinicializar("PG", iterac);

        var termo2 = pg1.TermoAt(posic);
        Console.WriteLine($"O termo da P.G. na posição {posic} é: " + termo2);
        Console.WriteLine("__________________________________________________________________");
    }
}

