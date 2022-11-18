namespace AulaOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Televisao t = new Televisao();
            while (true)
            {
                Console.WriteLine("digite 1 para ligar");
                Console.WriteLine("digite 2 para desligar");
                Console.WriteLine("digite 3 para verificar se esta ligado");
                Console.WriteLine("digite 4 para sair");
                op = int.Parse(Console.ReadLine());

                if(op == 1)
                {
                    //if (t.verificaLigado())
                    if(t.Ligado)
                    {
                        Console.WriteLine("ja esta ligado");
                    }
                    else
                    {
                        t.Ligar();
                    }
                }

                else if(op == 2)
                {
                    //if (!t.verificaLigado())
                    if (t.Ligado)
                    {
                        Console.WriteLine("ja esta ligado");
                    }
                    else
                    {
                        t.Desligar();
                    }
                }

                else if(op == 3)
                {
                    //if (t.verificaLigado())
                    if (t.Ligado)
                    {
                        Console.WriteLine("esta ligado");
                    }
                    else
                    {
                        Console.WriteLine("esta desligado");
                    }
                }

                else if(op == 4)
                {
                    break;
                }






















            }

        }
    }
}