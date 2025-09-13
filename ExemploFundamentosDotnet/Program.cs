using ExemplosFundamentosDotnet.Common.models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("PE");
listaString.Add("MG");
listaString.Add("RJ");


Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


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