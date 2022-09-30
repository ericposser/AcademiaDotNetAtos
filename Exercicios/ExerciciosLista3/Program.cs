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
            
            // EX 11
            string num;
            int alunos = 0;
            double nota, media = 0, menor=100 , maior=0 ;
            for(; ; )
            {
                Console.WriteLine("quer continuar?(se sim digite qualquer tecla, se nao digite -1");
                num = Console.ReadLine();
                if (num == "-1") { break; }
                else
                {
                    alunos++;
                    Console.WriteLine("qual foi a nota do aluno?");
                    nota=double.Parse(Console.ReadLine());
                    media = nota + media;
                    if (nota < menor)
                    {
                        menor = nota;
                    }
                     if(nota>maior){
                        maior = nota;
                    }
                }
            }
            media = media / alunos;
            Console.WriteLine("media da turma: "+media+ "\nmenor nota: "+menor+"\nmaior nota:"+maior);
            
            // EX 12
            
             int  soma=0;
            for(int i = 0; i < 100; i++)
            {
                
                soma = soma + i;
            }
            Console.WriteLine("Soma de todos:"+soma);
            
            // EX 13
            int num, soma = 0;
            for (int i = 0; i < 500; i++)
            {
                if (i % 2 == 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine("Soma de todos:" + soma);
            
            // EX 14
            double b = 2; 
            for (int i = 0; i <= 10; i++)
            {
                double p = i;
                double num;
                num = Math.Pow(b, p);
                Console.WriteLine(num);
            }
            
            // EX 15
            double nota1, nota2, nota3, nota4,media;
            Console.WriteLine("Escreva suas 4 notas");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());
            nota4 = double.Parse(Console.ReadLine());
            media = (nota1 * 2) + nota2 + (nota3 * 2) + (nota4 * 4);
            media = media / 9;
            if (media >= 7)
            {
                Console.WriteLine("aprovado");
            }
            else
            {
                Console.WriteLine("reprovado");
            }

            // EX 16
            double num;
            Console.WriteLine("digite o numero");
            num=double.Parse(Console.ReadLine());
            if (num <= 50)
            {
                for (int i = 1; ; i++)
                {
                    double produto = num * (Math.Pow(3, i));
                    if (produto > 250)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(produto);
                    }
                }
                
                // EX 17
                double quadrado;
                for (int i = 15; i <= 200; i++)
                {
                    quadrado = i * i;
                    Console.WriteLine(i+" ao quadrado="+quadrado);
                }

                
                // EX 18
                double p, b,e;
                Console.WriteLine("Digite qual base deseja?");
                b=double.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite qual expoente deseja");
                e=double.Parse(Console.ReadLine());
                
                p= Math.Pow(b,e);
                
                Console.WriteLine("A potencia ficou= "+p);
            
                // EX 19
                 int salario, media_salario=0, filhos, media_filhos=0,psalario=0,familia=0, maior=0;
                for(; ; )
                {
                    Console.WriteLine("qual seu salario?");
                    salario=int.Parse(Console.ReadLine());
                    if (salario < 0)
                    {
                        break;
                    }
                    else
                    {
                        familia++;
                        media_salario = salario + media_salario;
                        if (salario > maior)
                        {
                            maior = salario;
                        }
                        if (salario < 100)
                        {
                            psalario++;
                        }
                    }
                    Console.WriteLine("quantos filhos voce tem?");
                    filhos = int.Parse(Console.ReadLine());
                    media_filhos= filhos+ media_filhos;
                }
                media_salario = media_salario / familia;
                
                psalario = psalario * 100 / familia;
                
                media_filhos= media_filhos / familia;
                
                Console.WriteLine("o maior salario eh de:"+maior+"R$\nA media de salario eh de:"+media_salario+"R$\nA porcentagem de pessoas que ganham menos de 100R$ eh de:"+psalario+"%\n A media de filhos eh de:"+media_filhos);
            
        }
    }
}
