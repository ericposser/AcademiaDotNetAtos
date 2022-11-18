using System.Security.Cryptography;

namespace AulaInterface
{
    internal class Program
    {
        static List<Pessoa> pessoas;
        static void Main(string[] args)
        {
            pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa("ricardo", 40));
            pessoas.Add(new Pessoa("jeferson", 25));
            pessoas.Add(new Pessoa("miriam", 45));

            //foreach (Pessoa p in pessoas)
            //{
            //    Console.WriteLine(p.nome +  " " + p.idade);
            //}

            //ListaNaoOrdenada();

            ListaInserirItemPosicao();


        }
        static void ListaNaoOrdenada()
        {
            Console.WriteLine("Lista nao ordenada");
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.nome + " " + p.idade);
            });
        }

        static void ListaInserirItemPosicao()
        {
            Console.WriteLine("inserindo uma pessoa na posicao 1 e outra na posicao 3");

            pessoas.Insert(1, new Pessoa() { nome = "Eric", idade = 78 });
            pessoas.Insert(3, new Pessoa() { nome = "ricardo", idade = 60 });
        }





    }
}