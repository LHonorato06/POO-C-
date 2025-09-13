using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentosDotnet.Common.models 
{
    public class Pessoa
    {
        public String Nome { get; set; }
        public int Idade { get; set; }
        public string NomeRepresentanteLegalDaPessoaFisica { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Oi, meu nome é {Nome}, e tenho {Idade} anos.");
        } 
    }
}