using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Certidao
{
    public class CertidaoNascimento
    {
        [Required]
        public DateTime DataEmissao { get; set; }
        public Pessoa Pessoa { get; set; }

        public CertidaoNascimento(Pessoa pessoa, DateTime dataEmissao)
        {
            this.DataEmissao = dataEmissao;
            this.Pessoa = pessoa;      // Certidao referencia a Maria
            pessoa.Certidao = this;  // Maria referencia a certidao aqui
        }
    }
}
