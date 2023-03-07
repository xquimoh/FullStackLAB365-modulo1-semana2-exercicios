using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{

    // Conceitos iniciais

    public class Pessoa // Classe pública chamada Pessoa
    {
        // Atributos públicos da classe Pessoa: Nome e Idade
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor para Pessoa
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        // Método público Apresentar
        public void Apresentar( )
        {
            Console.WriteLine("Olá, meu nome é {nome} e tenho {idade} anos.");
        }
    }
}