using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoli
{
    internal class Animal
    {
        protected string nome;
        protected string sexo;
        protected string raca;


        public Animal(string nome, string sexo, string raca)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.raca = raca;
        }

        public void EmitirSom()
        {
            Console.WriteLine("Som do animal");
        }
        public void Dormir()
        {
            Console.WriteLine("Ta a mimir");
        }
        public void Caminhar()
        {
            Console.WriteLine("Esta a andar");
        }
        public void MostraDados()
        {
            Console.WriteLine("nome: " + nome + " sexo " + sexo + " raça " + raca + " peso " + peso);
        }
    }
}
