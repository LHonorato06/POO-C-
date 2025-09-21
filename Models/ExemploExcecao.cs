// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemploExplorando.Models
// {
//     public class ExemploExcecao
//     {
//         public void metodo1()
//         {
//             metodo2();
//         }
//         public void metodo2()
//         {
//             metodo3();
//         }
//         public void metodo3()
//         {
//             try
//             {
//                 metodo4();
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine("Exceção tratada." + ex.StackTrace);
//             }
//         }
//         public void metodo4()
//         {
//             throw new Exception("Ocorreu uma exceção");
//         }
//     }
// }