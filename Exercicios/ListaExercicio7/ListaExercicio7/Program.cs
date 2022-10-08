namespace ListaExercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EX 1
            //string titulo;
            //string autor;
            //int numeroPaginas;

            //Console.WriteLine("Digite o titulo do livro: ");
            //titulo = Console.ReadLine();

            //Console.WriteLine("Digite o autor do livro: ");
            //autor = Console.ReadLine();

            //Console.WriteLine("Digite o numero de paginas do livro: ");
            //numeroPaginas = int.Parse(Console.ReadLine());

            // EX 2
            string nome;
            int idade;
            float peso;
            float altura;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            pessoa dadosPessoa = new pessoa(nome, idade, peso, altura);

            dadosPessoa.exibirDados();

            // EX 3


        }
    }
}