// See https://aka.ms/new-console-template for more information
using Explorando_c_.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Karma";
p1.SobreNome = "Angelo";
p1.Idade = 22;

Pessoa p2 = new Pessoa(nome:"Deltina",sobreNome:"Gatinha");
p2.Idade = 22;

Cursos cursoIngles = new Cursos();
cursoIngles.Nome = "Inglês";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdcionarAlunos(p1);
cursoIngles.AdcionarAlunos(p2);
cursoIngles.ListaAlunos();





