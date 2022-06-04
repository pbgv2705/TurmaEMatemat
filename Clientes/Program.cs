using Clientes;

class Program
{
    public static void Main(string[] args)
    {
        string nome = "", data_str = "", espacos = "";
        long cpf = 0;
        DateTime data = DateTime.Today;
        float renda = 0.0f;
        char edoCivil = ' ';
        int depend = 0, n = 0, nroErr = 0;
        bool temErro = true;
        bool listaErro = false;
        string[] erros = new string[6] { ".", ".", ".", ".", ".", "." };
        Console.WriteLine("Bem-vindos ao Módulo de Clientes!");

        while (temErro)
        {
            listaErro = false;
            Console.WriteLine();
            Console.WriteLine("==========================================================");
            Console.WriteLine("Favor indique os seguintes dados:");
            Console.WriteLine();

            if (!(erros[0].Equals(espacos)))
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
            }
            if (!(erros[1].Equals(espacos)))
            {
                Console.Write("CPF: ");
                cpf = long.Parse(Console.ReadLine());
            }
            if (!(erros[2].Equals(espacos)))
            {
                erros[2] = "";
                try
                {
                    Console.Write("Data de Nascimento: ");
                    data_str = Console.ReadLine();
                    data = DateTime.Parse(data_str);
                    erros[2] = ".";
                }
                catch (Exception ex)
                {
                    erros[2] = data_str + " - Formato inválido. Favor indicar DD/MM/YYYY - ";
                }
            }
            if (!(erros[3].Equals(espacos)))
            {
                Console.Write("Renda Mensal: ");
                renda = float.Parse(Console.ReadLine());
            }
            if (!(erros[4].Equals(espacos)))
            {
                Console.Write("Estado Civil (C/S/V/D): ");
                edoCivil = char.Parse(Console.ReadLine());
            }
            if (!(erros[5].Equals(espacos)))
            {
                Console.Write("Dependentes: ");
                depend = int.Parse(Console.ReadLine());
            }

            var cliente = new Cliente(nome, cpf, data, renda, edoCivil, depend, erros);
           
            cliente.Valida(nome, cpf, data_str, renda, edoCivil, depend, erros);

            nroErr = 0;
            foreach (var item in erros)
            {
                if (item == "")
                {
                    temErro = false;
                    n ++;
                }
                else
                {
                    if (listaErro == false) // imprime cabeçalho
                    {
                        Console.WriteLine();
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine("Lista de Erros");
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine();
                        listaErro = true;
                    }
                    Console.WriteLine(item); // imprime lista de erros
                    temErro = true;
                    nroErr++;
                }
            }
            if (nroErr == 0) // não tem erros
            {
                Console.WriteLine();
                Console.WriteLine("_____________________________________________________________");
                Console.WriteLine();
                Console.WriteLine("Todos os dados verificados com sucesso:");
                Console.WriteLine("Nome do Cliente: " + nome);
                Console.WriteLine("CPF             : " + cpf);
                Console.WriteLine("Data Nascimento : " + data_str);
                Console.WriteLine("Renda Mensal    : " + "{0:N2}", renda);
                Console.WriteLine("Estado Civil    : " + edoCivil);
                Console.WriteLine("Dependentes     : " + depend);
                Console.WriteLine();
                Console.WriteLine("______________________________________________________________");
            }
            else
                temErro = true;
        }
    }
}