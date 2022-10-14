namespace ExerciciosLista8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n1, n2, n3;
            int p1, p2, p3;

            Console.WriteLine("Digite o nome do personagem 1: ");
            n1 = Console.ReadLine();

            Console.WriteLine("Digite o nome do personagem 2: ");
            n2 = Console.ReadLine();

            Console.WriteLine("Digite o nome do personagem 3: ");
            n3 = Console.ReadLine();

            Console.WriteLine("Digite o poder do personagem 1 (0 a 10): ");
            p1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o poder do personagem 2 (0 a 10): ");
            p2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o poder do personagem 3 (0 a 10): ");
            p3 = int.Parse(Console.ReadLine());

            Personagem perso = new Personagem(n1, n2, n3, p1, p3);

            perso.MostraDados();


        }
    }
}