using Clientes;

class Program
{
    public static void Main(string[] args)
    {
        string nome = "";
        long cpf = 0;
        DateTime data = DateTime.Today;
        float renda = 0.0f;
        char edoCivil = ' ';
        int depend = 0;
        bool temErro = true;
        bool listaErro = false;
        string[] erros = new string[6] { ".", ".", ".", ".", ".", "." };
        Console.WriteLine("Bem-vindos ao Módulo de Clientes!");

        while (temErro)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("Favor indique os seguintes dados:");
            Console.WriteLine();

            if (erros[0] != "")
            {
                if (erros[0] != ".")
                {
                    Console.WriteLine("O Nome");
                }
                Console.Write("Nome: ");
                nome = Console.ReadLine();
            }
            if (erros[1] != "")
            {
                Console.Write("CPF: ");
                cpf = long.Parse(Console.ReadLine());
            }
            if (erros[2] != "")
            {
                Console.Write("Data de Nascimento: ");
                data = DateTime.Parse(Console.ReadLine());
            }
            if (erros[3] != "")
            {
                Console.Write("Renda Mensal: ");
                renda = float.Parse(Console.ReadLine());
            }
            if (erros[4] != "")
            {
                Console.Write("Estado Civil (C/S/V/D): ");
                edoCivil = char.Parse(Console.ReadLine());
            }
            if (erros[5] != "")
            {
                Console.Write("Dependentes: ");
                depend = int.Parse(Console.ReadLine());
            }

            var cliente = new Cliente(nome, cpf, data, renda, edoCivil, depend, erros);
           
            cliente.Valida(nome, cpf, data, renda, edoCivil, depend, erros);
            
            foreach (var item in erros)
            {
                if (item == "")
                    temErro = false;
                else
                {
                    if (listaErro == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine("Lista de Erros");
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine();
                        listaErro = true;
                    }
                    Console.WriteLine(item);
                    temErro = true;
                }
            }
        }
    }
}