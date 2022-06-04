using System.ComponentModel.DataAnnotations;

namespace Certidao
{
    public class Pessoa
    {
        [Required]
        public string Nome { get; set; }
        public CertidaoNascimento Certidao { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        
    }
}
