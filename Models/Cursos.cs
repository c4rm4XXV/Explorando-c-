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
            for(int i = 0; i < Alunos.Count; i++)
            {
                //string texto = "Aluno N" + (i+1) + "º: " + Alunos[i].NomeCompleto;
                Console.WriteLine($"Aluno N{i+1}º: {Alunos[i].NomeCompleto}");
            }
        }
    }
}