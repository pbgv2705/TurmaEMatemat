using System.Text.RegularExpressions;

namespace Clientes
{
    public class Cliente
    {
        public string Nome { get; private set; }

        public long CPF { get; private set; }
        public DateTime DataNascim { get; private set; }
        public double RendaMensal { get; private set; }
        public char EdoCivil { get; private set; }
        public int Dependentes { get; private set; }
        public string[] Erros { get; set; }

        public Cliente(string nome, long cpf, DateTime dataNascim,
            double rendaMensal, char edoCivil, int dependentes, string[] err)
        {
            Nome = nome;
            CPF = cpf;
            DataNascim = dataNascim;
            RendaMensal = rendaMensal;
            EdoCivil = edoCivil;
            Dependentes = dependentes;
            Erros = err;
        }

        public string Valida(string nome, long cpf, string dataNascim, double rendaMensal, char edoCivil, int dependentes, string[] erros)
        {
            string erro_cpf = "", str_pto = ".", str_vazia = "";

            if (nome.Length < 5)
            {
                Erros[0] = Nome + " - O nome é incorreto. Deve ter ao menos 5 caracteres";
            }
            else
                Erros[0] = "";

            ValidaCpf valida = new ValidaCpf(cpf);
            erro_cpf = "";
            erro_cpf = valida.IsCpf(cpf);
            if (!(erro_cpf.Equals(str_vazia)))
            {
                Erros[1] = erro_cpf;
            }
            else
                Erros[1] = "";

            if (Erros[2].Equals(str_pto))
            {
                Erros[2] = "";
            }
            DateTime dataN = DateTime.Parse(DataNascim.ToString());
            if ((DateTime.Today.Year - DataNascim.Year) < 18)
            {
                Erros[2] += dataNascim + " - O cliente deve ter ao menos 18 anos";
            }

            Regex rendex = new System.Text.RegularExpressions.Regex(@"^\d+,\d{2}$");
            // No funciona. Não consegui o erro da regex.
            if (!rendex.IsMatch(RendaMensal.ToString()))
            {
                Erros[3] = RendaMensal + " - Renda Mensal incorreta. Favor indicar vírgula e 2 casas decimais";
            }
            else
                Erros[3] = "";

            if (RendaMensal <= 0)
            {
                Erros[3] = RendaMensal + " - Renda Mensal deve ser maior do que 0";
            }
            else
                Erros[3] = "";

            if (EdoCivil == 'S' || EdoCivil == 's' || EdoCivil == 'C' || EdoCivil == 'c' ||

                EdoCivil == 'V' || EdoCivil == 'v' || EdoCivil == 'D' || EdoCivil == 'd')
            {
                Erros[4] = "";
            }
            else
                Erros[4] = EdoCivil + " - Estado Civil incorreto. Favor indicar S/C/V/D";

            if (Dependentes < 0 || Dependentes > 10)
            {
                Erros[5] = Dependentes + " - Dependentes deve ser mínimo 0 e máximo 10";
            }
            else
                Erros[5] = "";

            return Erros[5];

        }


    }
}
