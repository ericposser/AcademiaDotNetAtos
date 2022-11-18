using System.Globalization;

namespace AulaDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //adicionando elementos a um dicionario
            Dictionary<int, string> dic1 = new Dictionary<int, string>();
            dic1.Add(1, "Maria");
            dic1.Add(2, "Paulo");
            dic1.Add(3, "Eric");

            //listando nome e id do dicionario
            foreach(KeyValuePair<int, string> item in dic1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("------------------");

            //retorna 1 valor especifico
            Console.WriteLine(dic1[2]);

            Console.WriteLine("------------------");

            //busca 1 valor se existir mostra na tela se nao fala que nao foi possivel achar
            string resultado;
            if(dic1.TryGetValue(1, out resultado))
            {
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("nao foi possivel achar a chave especificada");
            }

            Console.WriteLine("------------------");

            // se existir retorna true se nao existir retorna false
            Console.WriteLine(dic1.ContainsKey(1)); // retorna true

            Console.WriteLine(dic1.ContainsKey(6)); // retorna false

            Console.WriteLine(dic1.ContainsValue("Eric")); // retorna true

            Console.WriteLine("------------------");

            //remove um elemento
            dic1.Remove(2); // removendo um elemento

            foreach (KeyValuePair<int, string> item in dic1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("------------------");
            Console.WriteLine("------------------");

            //criando dicionario ordenado
            SortedDictionary<string, int> dic2 = new SortedDictionary<string, int>();
            dic2.Add("zebra", 5);
            dic2.Add("cachorro", 2);
            dic2.Add("gato", 9);
            dic2.Add("passaro", 100);

            //verifica se tem gato
            if (dic2.ContainsKey("gato"))
            {
                Console.WriteLine("tem um gato ai");
            }

            Console.WriteLine("------------------");

            //verivica se tem zebra
            if (dic2.ContainsKey("zebra"))
            {
                Console.WriteLine("tem uma zebra ai");
            }

            Console.WriteLine("------------------");

            // e se tiver pega o valor
            int v;
            if(dic2.TryGetValue("gato", out v))
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("------------------");

            //imprime ordenando em odem alfabetica
            foreach (KeyValuePair<string, int> p in dic2)
            {
                Console.WriteLine(p.Key + " " + p.Value);
            }

        }
    }
}