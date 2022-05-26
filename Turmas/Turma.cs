using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turmas
{
    internal class Turma
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }

        public Turma(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
        public string RemoverAluno(string nome)
        {
            return Nome;

        }
    }
}
