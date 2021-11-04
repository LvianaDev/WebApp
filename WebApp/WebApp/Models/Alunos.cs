using System.Collections.Generic;

namespace WebApp.Models
{
    public class Alunos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public int Ra { get; set; }

        public List<Alunos> listaAlunos()
        {
            Alunos aluno = new Alunos();
            aluno.Id = 1;
            aluno.Nome = "Lucas";
            aluno.Sobrenome = "Viana";
            aluno.Telefone = "11961345881";
            aluno.Ra = 00001;

            List<Alunos> listaAlunos = new List<Alunos>();

            listaAlunos.Add(aluno);

            return listaAlunos;
        }
    }
}