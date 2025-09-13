using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Lucas", "Assis");
// p1.Idade = 18;
// p1.Apresentar();

Pessoa p2 = new Pessoa();
p1.Nome = "Carlos";
p1.Sobrenome = "Eduardo";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();



