using CarrosEMotores;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Módulo de Carros e Motores");
        Console.WriteLine("__________________________________________________________________________");
        var motor1 = new Motor(80015, 1.0, 0);
        var motor2 = new Motor(80016, 1.0, 0);
        var motor3 = new Motor(80017, 1.6, 0);
        var motor4 = new Motor(90021, 2.0, 0);
        var motor5 = new Motor(90025, 2.8, 0);
        Console.WriteLine("foram criados com sucesso os motores motor1, motor2, motor3, motor4 e motor5");

        motor1.Instalado = 1;
        var carro1 = new Carro("AKO001", "Hatchback", motor1);
        Console.WriteLine($"Foi instalado com sucesso o motor {motor1.CodigoMotor} no carro {carro1.Placa}");
        motor2.Instalado = 1;
        var carro2 = new Carro("BLI103", "Sedã", motor2);
        Console.WriteLine($"Foi instalado com sucesso o motor {motor2.CodigoMotor} no carro {carro2.Placa}");
        motor3.Instalado = 1;
        var carro3 = new Carro("KZE225", "Perua", motor3);
        Console.WriteLine($"Foi instalado com sucesso o motor {motor3.CodigoMotor} no carro {carro3.Placa}");

        // LINHAS SEGUINTES PARA TESTAR QUE UM MOTOR NÃO PODE SER INSTALADO ENM 2 CARROS:

        // Trocar o motor de um carro
        // bool troca1 = carro1.TrocarMotor(motor2);
        // if (troca1)  
        //     Console.WriteLine($"O motor {motor2} foi instalado com sucesso no carro {carro1} ");

        bool troca2 = carro2.TrocarMotor(motor4);
        if (troca2)
            Console.WriteLine($"O motor {motor4.CodigoMotor} foi trocado e instalado com sucesso no carro {carro2.Placa} ");

        Console.WriteLine(carro1.CalculaVelocidad());
        Console.WriteLine(carro2.CalculaVelocidad());
        Console.WriteLine(carro3.CalculaVelocidad());

    }

}