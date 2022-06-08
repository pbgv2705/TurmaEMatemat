using System.ComponentModel.DataAnnotations;

namespace CursosETurmas
{
    public class Curso
    {
        [Required]
        public string Nome { get; set; }

        public Curso(string nome)
        {
            Nome = nome;
        }

        public void MatricularAluno()
        {

        }
        public void RemoverAluno()
        {
            // somente se aluno não está associado a uma turma

        }
        public void CriarTurma()
        {

        }
        public void RemoverTurma()
        {
            // somente se a turma não tiver nenhum aluno associado a ela
        }
        public void InserirRemoverAluno()
        {

        }
        public void ListarAlunos()
        {

        }
        public void ListarTurmas()
        {

        }

    }



}
