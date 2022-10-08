using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio7
{
    internal class pessoa
    {
        private string nome;
        private float altura;
        private float peso;
        private int idade;

        public pessoa(string? nome, int idade, float peso, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }

        public void exibirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Idade: " + idade);
        }
    }
}
