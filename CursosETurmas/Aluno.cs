using System.ComponentModel.DataAnnotations;

namespace CursosETurmas
{
    public class Aluno
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Matricula { get; set; }
        
        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

    }
}
