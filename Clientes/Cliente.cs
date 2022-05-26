
using Clientes.Exceptions;
using System.Globalization;
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

        public Cliente(string nome, long cPF, DateTime dataNascim, 
            double rendaMensal, char edoCivil, int dependentes, string[] err)
        {
            Nome = nome;
            CPF = cPF;
            DataNascim = dataNascim;
            RendaMensal = rendaMensal;
            EdoCivil = edoCivil;
            Dependentes = dependentes;
            //for (int i = 0; i < err.Length; i++)
            //{
            //    Erros[i] = err[i];
            //}
            Erros = err;
        }

        public string Valida(string nome, long cpf, DateTime dataNascim, double rendaMensal, char edoCivil, int dependentes, string[] erros)
        {
            
            if (nome.Length < 5)
            {
                Erros[0] = "Nome: " + Nome + " Incorreto! Deve ter ao menos 5 caracteres"; 
            }else
                Erros[0] = "";
            
            ValidaCpf valida = new ValidaCpf(cpf);
            bool isValido = valida.IsCpf(cpf);
            if (!isValido)
            {
                Erros[1] = "CPF: " + CPF + " não é válido";
            }
            else
                Erros[1] = "";

            //string pattern = "dd/MM/yyyy";

            //if (DateTime.TryParseExact(DataNascim, pattern, null,
            //                                   DateTimeStyles.None, out DateTime data))
            //    Console.WriteLine();
            //else
            //    Console.WriteLine("Favor indicar DD/MM/YYYY", DataNascim);

            // DateTime dataN = DateTime.Parse(DataNascim.ToString());
            if ((DateTime.Today.Year - DataNascim.Year) < 18)
                    {
                        Erros[2] = "Data de Nascimento: " + DataNascim + "O cliente deve ter ao menos 18 anos";
                    }
                    else
                        Erros[2] = "";

            Regex rendex = new System.Text.RegularExpressions.Regex(@"^(\d|-)?(\d|.)*\,?\d*$");
            // No funciona 
            if (!rendex.IsMatch(RendaMensal.ToString()))
            {
                Erros[3] = "Renda: " + RendaMensal + " Favor indicar vírgula e 2 casas decimais";
            }
            else
                Erros[3] = "";

            if (EdoCivil == 'S' || EdoCivil == 's' || EdoCivil == 'C' || EdoCivil == 'c' ||  
            
                EdoCivil == 'V' || EdoCivil == 'v' || EdoCivil == 'D' || EdoCivil == 'd')
            {
                Erros[4] = "";
            }
            else
                Erros[4] = "Estado Civil: " + EdoCivil + " Incorreto. Favor indicar S/C/V/D";

            if (Dependentes <0 || Dependentes > 10)
            {
                Erros[5] = "Dependentes: " + Dependentes + " deve ser mínimo 0 e máximo 10";
            }
            else
                Erros[5] = "";

            return Erros[5];

        }

       
    }
}
