using System;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;

namespace Lista4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLO AULA
            int i;
            int[] b = new int[5];

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o valor de " + i + ":");
                b[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("valor indice: " + i + " e igual a " + b[i]);
            }

            //EXEMPLO AULA
            double[] notas = new double[50];
            double media;
            int i;

            for (i = 0; i < 50; i++)
            {
                Console.WriteLine("Digite a nota do aluno " + i + ":");
                notas[i] = double.Parse(Console.ReadLine());
            }

            media = 0;
            for (i = 0; i < 50; i++)
            {
                media += notas[i];
            }

            media = media / 50;

            Console.WriteLine("A media de notas eh igual " + media);

            //EXEMPLO AULA
            int[] vetor = new int[10];
            int i, maior, pos, menor, posmenor;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor do elemento: " + i);
                vetor[i] = int.Parse(Console.ReadLine());
            }
            maior = vetor[0];
            pos = 0;
            menor = vetor[0];
            posmenor = 0;

            for (i = 0; i < 10; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    pos = i;
                }
                else if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posmenor = i;
                }
            }

            Console.WriteLine("O maior elemento eh: " + maior + " e esta na posicao: " + pos);
            Console.WriteLine("O menor elemento eh: " + menor + " e esta na posicao: " + posmenor);


            //EX 1
            int[] vetor = new int[10];
            int i, par = 0, impar = 0;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite os valores do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }


            Console.WriteLine("Quantidade de numeros pares: " + par + " e quantidade de numeros impares: " + impar);


            //EX 2
            int[] vetor1 = new int[20], vetor2 = new int[20], vetor3 = new int[20];
            int i, soma;

            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite os valores para o primeiro vetor na posicao: " + i);
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite os valores para o segundo vetor na posicao: " + i);
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 20; i++)
            {
                vetor3[i] = vetor1[i] + vetor2[i];

                Console.WriteLine("A soma dos vetores na posicao:" + i + ":" + vetor3[i]);
            }

            //EX 3
            int[] vetor = new int[20];
            int qtdDiv = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite o valor da posicao " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
                for (int j = 1; j <= vetor[i]; j++)
                {
                    if (vetor[i] % j == 0)
                    {
                        qtdDiv++;
                    }
                }
                if (qtdDiv == 2)
                {
                    Console.WriteLine("Indice " + i);
                    qtdDiv = 0;
                }
            }

            //EX 4
            int[] vetor1 = new int[10], vetor2 = new int[10], vetor3 = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite os valores para o primeiro vetor na posicao: " + i);
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite os valores para o segundo vetor na posicao: " + i);
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                vetor3[i] = vetor1[i] * vetor2[i];

                Console.WriteLine("A soma dos vetores na posicao:" + i + ":" + vetor3[i]);
            }


            //EX 5
            int[] vetor = new int[10];
            int i, menor, pos;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor do elemento: " + i);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            pos = 0;
            menor = vetor[0];


            for (i = 0; i < 10; i++)
            {

                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    pos = i;
                }
            }

            Console.WriteLine("O menor elemento eh: " + menor + " e esta na posicao: " + pos);

            //EX 6
            int[] vetor = new int[10];

            int[] vetorCont = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite os valores para o vetor:");
                vetor[i] = int.Parse(Console.ReadLine());

                vetorCont[vetor.Length - (i + 1)] = vetor[i];
            }

            for (int i = 0; i < vetorCont.Length; i++)
            {
                Console.WriteLine(vetorCont[i]);
            }

            //EX 7
            int[] vetor = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor do elemento: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("---------------------");

            for (i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }

            for (i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 1)
                {
                    Console.WriteLine(vetor[i]);
                }
            }

            //EX 8
            double[] vetor = new double[5];
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite os valores para o vetor: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("---------------------");

            for (i = 0; i < 5; i++)
            {
                if (vetor[i] < 0)
                {
                    Console.WriteLine(i);
                }
            }

            //EX 9
            int[] vetor = new int[10], vetoraux = new int[10];
            int i, aux = 0;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite os valores para o vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                aux = vetor[i];
                vetor[i] = vetoraux[i];
                vetoraux[i] = aux;

                Console.WriteLine(vetoraux[i]);
            }

            //EX 10

            //EX 11
            int[] vetor = new int[5];
            int i;
            int[] vetorCont = new int[5];

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite os valores para o vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());

                vetorCont[vetor.Length - (i + 1)] = vetor[i];
            }

            Console.WriteLine("--Valores em ordem--");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("--Valores em ordem inversa--");

            for (i = 0; i < vetorCont.Length; i++)
            {
                Console.WriteLine(vetorCont[i]);
            }

            //EX 12
            int[] vetor = new int[3];
            int i, n, cont = 0;

            Console.WriteLine("Digite o numero: ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite os valores para o vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 3; i++)
            {
                if (n == vetor[i])
                {
                    Console.WriteLine("Seu numero existe na posicao: " + i);
                    cont++;
                }

            }

            if(cont == 0)
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }


            //EX 13
            int[] vetor = new int[100];
            int i, cont = 0;

            for (i = 0; i < 100; i++)
            {
                Console.WriteLine("Digite os valores para o vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());

            }


            //EX 14
            for (i = 0; i < 100; i++)
            {
                if (vetor[i] == 2)
                {
                    cont++;
                }
                else if (vetor[i] == 4)
                {
                    cont++;
                }
                else if (vetor[i] == 8)
                {
                    cont++;
                }
            }

            Console.WriteLine("Os numeros 2, 4 e 8 aparecem: " + cont + " vezes");


            int[] vetor = new int[50];
            int i, opcao;
            int[] vetorCont = new int[50];

            for (i = 0; i < 50; i++)
            {
                Console.WriteLine("Digite os valores para o vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());

                vetorCont[vetor.Length - (i + 1)] = vetor[i];
            }

            Console.WriteLine("--MENU--");
            Console.WriteLine("0 - sair");
            Console.WriteLine("1 - ler vetor em ordem");
            Console.WriteLine("2 - ler vetor em ordem decrescente");
            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------");


            switch (opcao)
            {

                case 1:
                    for (i = 0; i < 50; i++)
                    {
                        Console.WriteLine(vetor[i]);
                    }
                    break;

                case 2:
                    for (i = 0; i < vetorCont.Length; i++)
                    {
                        Console.WriteLine(vetorCont[i]);
                    }
                    break;

                case 0:
                    break;

                default:
                    Console.WriteLine("Opcao invalida!");
                    break;

            }

            //EX 15

            //EX 16



        }

    }
}

