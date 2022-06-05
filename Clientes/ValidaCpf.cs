namespace Clientes
{
    public class ValidaCpf
    {
        public long Cpf { get; private set; }

        public ValidaCpf(long cpf)
        {
            this.Cpf = cpf;
        }

        public string IsCpf(long cpf)
        {
            int[] multip1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multip2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = "", strCpf = "", erroCpf = "";
            string digito, digito1;
            int soma;
            int resto;
            bool diferentes = false;
            strCpf = Cpf.ToString();
            strCpf = strCpf.Trim();
            strCpf = strCpf.Replace(".", "").Replace("-", "");

            if (strCpf.Length != 11)
                erroCpf = strCpf + " - O CPF deve ter exatamente 11 digitos";

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
                    break;
                }
            }
            if (!diferentes)
            {
                erroCpf = strCpf + " - não válido. Deve ter digitos diferentes";
                return erroCpf;
            }

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multip1[i];
            resto = soma % 11;
            if (resto < 2)

                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf += digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multip2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            tempCpf += resto.ToString();
            if (Cpf == long.Parse(tempCpf))
            {
                erroCpf = "";
                return erroCpf;
            }
            else
            {
                erroCpf = strCpf + " - não é válido";
                return erroCpf;
            }   
        }
    }
}
