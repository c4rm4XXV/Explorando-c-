using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando_c_.Models
{
    public class Cursos
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        public void AdcionarAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int QuantidadesAlunosMatriculados ()
        {
            return Alunos.Count();
        }
        public bool RemoverAlunos(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void ListaAlunos ()
        {
            Console.WriteLine($"Alunos do curso {Nome}:");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine($"{aluno.NomeCompleto}");
            }
        }
    }
}