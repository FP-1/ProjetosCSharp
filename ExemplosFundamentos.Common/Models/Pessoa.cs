using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models
{
    /// <summary>
    /// Classe que representa uma pessoa
    /// </summary>
   
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

    /// <summary>
    /// Método que apresenta os dados da pessoa
    /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}
