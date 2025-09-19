using ExemploExplorando.Models;
using ExemplosFundamentosDotnet.Common.models;
using System.Data;
using System.Globalization;


int numero = 110;
bool ehPar = false;

//IF ternário 

ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));


















// Pessoa p1 = new Pessoa("lucas", "assis");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");


















// LeituraArquivo arquivo = new LeituraArquivo();
//                           //usam o "_" quando não precisa usar uma determinada variavel quatidadeLinhas//
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//   //Console.WriteLine("Quantidade linhas do arquivo:" + quatidadeLinhas);
//   foreach (string linha in linhasArquivo)
//   {
//     Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine("Não foi possível ler o arquivo");
// }
















// (int, string, string, decimal) tupla = (1, "lucas", "assis", 10.5M);
// // ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "lucas", "assis", 10.5M);
// // var outroExemploTuplaCreate = Tuple.Create(1, "lucas", "assis", 10.5M);

//   Console.WriteLine($"id: {tupla.Item1}");
//   Console.WriteLine($"Nome: {tupla.Item2}");
//   Console.WriteLine($"Sobrenome: {tupla.Item3}");
//   Console.WriteLine($"Altura: {tupla.Item4}");



















// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (var item in estados)
// {
//   Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// estados.Remove("BA");
// estados["SP"] = "São paulo - valor alterado!";

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//   Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//   Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");

// }
















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo:{pilha.Pop()} ");

// pilha.Push(4);

























// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: fila.Dequeue()");
// fila.Enqueue(10);



















// try
// {

//   string[] linhas = File.ReadAllLines("Arquivos/arquivosLeitura.txt");

//   foreach (string linha in linhas)
//   {
//     Console.WriteLine(linha);
//   }
// }
// catch (FileNotFoundException ex)
// {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//   Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//   Console.WriteLine("chegou até aqui");
// }



















// string datastring = "2022-13-17 18:00";

// bool sucesso = DateTime.TryParseExact(datastring, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//   Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//   Console.WriteLine($"{datastring} não é uma data válida");
// }

// DateTime data = DateTime.Parse("17/04/2022 18:00");

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));




// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("PE");
// listaString.Add("MG");
// listaString.Add("RJ");


// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


// Console.WriteLine("percorrendo o array com o FOR");
// for (int contador = 0; contador < listaString.Count; contador++)
// {
//   Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine("percorrendo o array com o FOREACH");
// int contadorForeach = 0;
// foreach (string item in listaString)
// {
//   Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//   contadorForeach++;
// }





























// int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("percorrendo o array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//   Console.WriteLine($"Posição nº {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("percorrendo o array com o FOREACH");
// foreach (int valor in arrayInteiros)
// {
//   Console.WriteLine(valor);
// }


















// using System.Diagnostics;



// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Lucas";
// pessoa1.Idade = 18;
// pessoa1.Apresentar();





// String opcao;
// bool Exibirmenu = true;

// while (Exibirmenu)
// {
//   Console.Clear();
//   Console.WriteLine("Digite a sua opção:");
//   Console.WriteLine("1 - Cadastrar cliente");
//   Console.WriteLine("2 - Buscar cliente");
//   Console.WriteLine("3 - Apagar cliente");
//   Console.WriteLine("4 -Encerrar");

//   opcao = Console.ReadLine();

//   switch (opcao)
//   {
//     case "1":
//       Console.WriteLine("Cadastro de cliente");
//       break;

//     case "2":
//       Console.WriteLine("Busca de cliente");
//       break;

//     case "3":
//       Console.WriteLine("Apagar cliente");
//       break;

//     case "4":
//       Console.WriteLine(" Encerrar");
//       Exibirmenu = false;
//       break;

//     default:
//       Console.WriteLine("Opção inválida");
//       break;
//   }   
// }
//    Console.WriteLine("programa se encerrou");












// int soma = 0, numero = 0;

// do
// {
//   Console.WriteLine("digite um número (0 para parar)");
//   numero = Convert.ToInt32(Console.ReadLine());
//   soma += numero;

// } while (numero != 0);
//   Console.WriteLine($"Total da soma dos números digitados é:{soma} ");













// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//   contador++;
//   if (contador == 6)
//   {
//    break; 
//   }
  
// }





// int numero = 10;

// for (int i = 0; i <= 10; i++) 
// {
//   Console.WriteLine($"{numero} x {i} = {numero * i}");
// }















// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;

//   default:
//     Console.WriteLine("Não é vogal");
//     break;
// }












// string a = "15-";
// int b = 0;

// int.TryParse(a, out b);



// int inteiro = 5;
// string a = inteiro.ToString();

// int b = Convert.ToInt32("5");




// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// // string apresentacao = "Olá, seja bem vindo";
// // int quatidade = 1;
// // double altura = 1.8;
// // decimal preco = 1.80M;
// // bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da váriavel quantidade: " + quatidade);
// Console.WriteLine("Valor da váriavel altura: " +altura.ToString("0.00"));
// Console.WriteLine("Valor da váriavel preco: " + preco);
// Console.WriteLine("Valor da váriavel condicao: " + condicao);
//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Lucas";
//pessoa1.Idade = 18;
//pessoa1.Apresentar();