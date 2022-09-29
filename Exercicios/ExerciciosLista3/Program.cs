using System.Drawing;
using System.Linq.Expressions;
using System.Xml;

namespace Lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EX 1
            int n;

            do
            {
                Console.WriteLine("Digite um numero positivo: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("Valor invalido!");
                }

                for (int i = 1; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Numeros entre 1 e " + n + ": " + i);
                    }
                }

            } while (n <= 0);

            //EX 2
            int n;
            string opcao;

            do
            {
                Console.WriteLine("Digite um numero positivo: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("Valor invalido!");
                }

                for (int i = 1; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Numeros pares entre 1 e " + n + ": " + i);
                    }
                }

                Console.WriteLine("Deseja informar outro número (s/n)?");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "n":
                        break;

                    case "s":
                        Console.WriteLine("Digite um numero positivo: ");
                        n = int.Parse(Console.ReadLine());

                        if (n <= 0)
                        {
                            Console.WriteLine("Valor invalido!");
                        }

                        for (int i = 1; i < n; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine("Numeros pares entre 1 e " + n + ": " + i);
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;

                }

            } while (n <= 0);


            //EX 3
            int n;

            do
            {
                Console.WriteLine("Digite um numero diferente de 0: ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine("Numero par");
                }
                else
                {
                    Console.WriteLine("Numero impar");
                }

                int qtd = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        qtd++;
                    }
                }

                if (qtd > 2)
                {
                    Console.WriteLine("Numero nao eh primo");
                }
                else
                {
                    Console.WriteLine("Numero primo");
                }

            } while (n != 0);


            //EX 4
            int joao = 0, zeca = 0, branco = 0;
            string voto;

            do
            {
                Console.WriteLine("Em quem voce deseja votar? joao/zeca/branco para finalizar digite fim");
                voto = Console.ReadLine();

                if (voto == "joao")
                {
                    joao++;
                }
                if (voto == "zeca")
                {
                    zeca++;
                }
                if (voto == "branco")
                {
                    branco++;
                }

            } while (voto != "fim");

            Console.WriteLine("Quantidade de votos para joao: " + joao + " zeca: " + zeca + " e em branco: " + branco);


            //EX 5
            int joao = 0, zeca = 0, branco = 0, nulo = 0, qtd = 0;
            string voto;

            do
            {
                Console.WriteLine("Em quem voce deseja votar? joao/zeca/branco para finalizar digite fim");
                voto = Console.ReadLine();

                if (voto == "joao")
                {
                    joao++;
                    qtd++;
                }
                else if (voto == "zeca")
                {
                    zeca++;
                    qtd++;
                }
                else if (voto == "branco")
                {
                    branco++;
                    qtd++;
                }
                else if (voto != "joao" || voto != "zeca" || voto != "branco")
                {
                    nulo++;
                    qtd++;
                }

            } while (voto != "fim");

            Console.WriteLine("Quantidade de votos para joao: " + joao + " zeca: " + zeca + " e em branco: " + branco);

            if (joao > zeca)
            {
                Console.WriteLine("Joao vencedor");
            }
            else
            {
                Console.WriteLine("Zeca vencedor");
            }


            Console.WriteLine("Numero de voto nulos: " + nulo);

            Console.WriteLine("Total de pessoas que votaram: " + qtd);

            //EX 6
            int idade;

            do
            {
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

            } while (idade < 0);

            Console.WriteLine("A idade digitada foi: " + idade);

            //EX 7
            string nome;
            int idade;
            float salario;
            do
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                if (nome.Any(char.IsDigit) || string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("Digite um nome válido!!");
                }
                else
                {
                    break;
                }
            } while (true);
            do
            {
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade <= 0)
                {
                    Console.WriteLine("Digite uma idade válida!!");
                }
                else
                {
                    break;
                }
            } while (true);
            do
            {
                Console.Write("Salário: ");
                salario = float.Parse(Console.ReadLine());
                if (salario <= 0)
                {
                    Console.WriteLine("Digite um salário válido!!");
                }
                else
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Seus dados são: ");
            Console.WriteLine("Nome: " + nome.ToUpper());
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salário: " + salario);

            //EX 8
            float n;
            string opcao;

            do
            {
                Console.WriteLine("Digite um numero inteiro");
                n = float.Parse(Console.ReadLine());

            } while (n % 1 != 0);

            if (n % 2 == 0)
            {
                Console.WriteLine("Numero par");
            }
            else
            {
                Console.WriteLine("Numero impar");
            }

            Console.WriteLine("Deseja repetir o programa? Sim ou Nao");
            opcao = Console.ReadLine();

            do
            {
                switch (opcao)
                {
                    case "sim":

                        do
                        {
                            Console.WriteLine("Digite um numero inteiro");
                            n = float.Parse(Console.ReadLine());

                        } while (n % 1 != 0);

                        if (n % 2 == 0)
                        {
                            Console.WriteLine("Numero par");
                        }
                        else
                        {
                            Console.WriteLine("Numero impar");
                        }

                        Console.WriteLine("Deseja repetir o programa? Sim ou Nao");
                        opcao = Console.ReadLine();

                        break;

                    case "nao":
                        break;

                }
            } while (opcao == "sim");


            //EX 9
            int UmTres = 0, QuatroSete = 0, OitoMais = 0, NenhumFilho = 0;
            int filho;

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Quantos filhos a familia possui: ");
                filho = int.Parse(Console.ReadLine());

                if (filho >= 1 && filho <= 3)
                {
                    UmTres++;
                }
                else if (filho >= 4 && filho <= 7)
                {
                    QuatroSete++;
                }
                else if (filho >= 8)
                {
                    OitoMais++;
                }
                else if (filho == 0)
                {
                    NenhumFilho++;
                }

            }

            Console.WriteLine("tem entre 1 e 3 filhos: " + UmTres);
            Console.WriteLine("tem entre 4 e 7 filhos: " + QuatroSete);
            Console.WriteLine("tem mais de 8 filhos: " + OitoMais);
            Console.WriteLine("não tem filhos: " + NenhumFilho);

            //EX 10
            int idade, sexoM = 0, sexoH = 0, menosTrinta = 0, maisSecenta = 0;
            string nome, sexo;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite seu sexo: (masculino ou feminino)");
                sexo = Console.ReadLine();

                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (sexo == "masculino")
                {
                    sexoH++;
                }
                else if (sexo == "feminino")
                {
                    sexoM++;
                }
                if (idade < 30)
                {
                    menosTrinta++;
                }
                else if (idade > 60)
                {
                    maisSecenta++;
                }


            }
            Console.WriteLine("Numero de pessoas do sexo masculino: " + sexoH);
            Console.WriteLine("Numero de pessoas do sexo feminino: " + sexoM);
            Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + menosTrinta);
            Console.WriteLine("Número de pessoas com idade superior a 60 anos: " + maisSecenta);



        }
    }
}