using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaInterface
{
    class Pessoa
    {
       public Pessoa() { }
        
        public string nome { get; set; }
        public int idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.idade = idade;
            this.nome = nome;
        }

       


    }
}
