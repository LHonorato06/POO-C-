using ExemploExplorando.Models;
using Newtonsoft.Json;

string conteudoAquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoAquivo);

foreach (Venda venda in listaVenda)
{
  Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
  $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}



























// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();


// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(1, "Licença de Software", 110.00M, dataAtual);
// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);








 
// Pessoa p1 = new Pessoa("Lucas", "Assis");
// // p1.Idade = 18;
// // p1.Apresentar();

// Pessoa p2 = new Pessoa();
// p1.Nome = "Carlos";
// p1.Sobrenome = "Eduardo";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();



