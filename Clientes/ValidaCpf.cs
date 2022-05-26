//using DomainExceptions;

using Clientes.Exceptions;

namespace Clientes
{
    public class ValidaCpf
    {
        public long Cpf { get; private set; }

        public ValidaCpf(long cpf)
        {
            this.Cpf = cpf;
        }

        public bool IsCpf(long cpf) {

            int[] multip1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multip2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = "", strCpf = "";
            string digito, digito1;
            int soma;
            int resto;
            bool diferentes = false;
            strCpf = Cpf.ToString();  
            strCpf = strCpf.Trim();
            strCpf = strCpf.Replace(".", "").Replace("-", "");
            
            if (strCpf.Length != 11)
                throw new DomainException(") CPF deve ter exatamente 11 digitos");

            tempCpf = strCpf.Substring(0, 9);
            soma = 0;

            digito1 = strCpf.Substring(0, 1);

            string test = "";
            for (int i = 0; i < 11; i++)
            {
                test = strCpf[i].ToString();
                if (digito1 != test)
                {
                    diferentes = true;
                   // Console.WriteLine("digito1: " + digito1 + ", tempCpf: " + strCpf[i].ToString());
                    break;
                }
            }
            if (!diferentes)
            {
                return false;
            }


            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multip1[i];
            resto = soma % 11;
            if (resto < 2)

                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multip2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            tempCpf = tempCpf + resto.ToString();
            if (Cpf == long.Parse(tempCpf))
            {
               // Console.WriteLine(tempCpf + ", " + Cpf + " true");
                return true;
            }
            else
               // Console.WriteLine(tempCpf + ", " + Cpf + " false" );
            return false;
        }
    }
}
