
using System.ComponentModel.DataAnnotations;

namespace Turmas
{
    public class Aluno
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Matricula { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }

        public Aluno(string nome, string matricula, double p1, double p2)
        {
            Nome = nome;
            Matricula = matricula;
            P1 = p1;
            P2 = p2;
        }

        public Aluno(string nome1, string matr1)
        {
            this.Nome = nome1;
            this.Matricula = matr1;
        }

        //public static implicit operator List<object>(Aluno v)
        //{
        //    throw new NotImplementedException();
        //}
    }

}
