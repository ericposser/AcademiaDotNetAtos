using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista7
{
    internal class Agenda
    {
        public List<Pessoa> pessoas = new List<Pessoa>();
        public String nome;
        public Agenda(string nome)
        {
            this.nome = nome;
            //carros = new List<Carro>();
        }
        //public int[] vet = new int[10];
        public void ArmazenaPessoa(String nome, int idade, float altura)
        {
            Pessoa p = new Pessoa(nome, idade, altura);
            pessoas.Add(p);

        }
        public Pessoa BuscaPessoa(String nome)
        {
            Pessoa r = null;
            foreach (Pessoa p in pessoas)
            {
                if (p.nome.Equals(nome))
                {
                    r = p;
                }
            }
            return r;

        }
        public void MostraPessoas()
        {
            /*for(int i = 0; i < carros.Count; i++)
            {
                Console.WriteLine("Carro "+i+": " + carros[i].modelo);
            }*/

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine("Nome: " + p.nome + " Idade: " + p.idade + " Altura: " + p.altura);
            }
        }
        public void RemovePessoa(String nome)
        {
            foreach (Pessoa p in pessoas)
            {
                if (p.nome.Equals(nome))
                {
                    //aqui devo apagar o carro da lista
                }
            }
        }
    }
}
