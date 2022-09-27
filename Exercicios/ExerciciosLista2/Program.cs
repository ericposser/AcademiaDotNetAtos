using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EX 1
            int b, a, area;

            Console.WriteLine("Digite a base: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            a = int.Parse(Console.ReadLine());  


            if (b == 0 || a == 0)
            {
                Console.WriteLine("base ou altura digitada é igual a 0");
            }
            else
            {
                area = (b * a) / 2;

                Console.WriteLine("A area é: " + area);
            }
            

            // EX 2
            int n;

            Console.WriteLine("digite o numero: ");
            n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("numero par");
            }
            else
            {
                Console.WriteLine("numero impar");
            }
            

            // EX 3
            int n1, n2, n3, n4, media;

            Console.WriteLine("Digite o valor 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 3: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 4: ");
            n4 = int.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4)/ 4;

            Console.WriteLine("a media é: " + media);

            if(n1 > media)
            {
                Console.WriteLine("valor 1 maior que a media");
            }
            if(n2 > media)
            {
                Console.WriteLine("valor 2 maior que a media");
            }
            if (n3 > media)
            {
                Console.WriteLine("valor 3 maior que a media");
            }
            if (n4 > media)
            {
                Console.WriteLine("valor 4 maior que a media");
            }
            


            // EX 4
            int horasProf1, horasProf2, valorProf1, valorProf2;
            float salarioProf1, salarioprof2;

            Console.WriteLine("quantidade de horas dadas pelo professor 1: ");
            horasProf1 = int.Parse(Console.ReadLine());

            Console.WriteLine("quantidade de horas dadas pelo professor 2: ");
            horasProf2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora dada pelo professor 1: ");
            valorProf1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora dada pelo professor 2: ");
            valorProf2 = int.Parse(Console.ReadLine());

            salarioProf1 = horasProf1 * valorProf1;

            salarioprof2 = horasProf1 * valorProf1;

            if(salarioProf1 > salarioprof2)
            {
                Console.WriteLine("salario do professor 1 é maior");
            }
            else
            {
                Console.WriteLine("salario do professor 2 é maior");
            }
            

            // EX 5
            float n1, n2, media, exame, mediaFinal, soma;

            Console.WriteLine("Digite a nota 1: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            n2 = float.Parse(Console.ReadLine());

            soma = n1 + n2;
            media = soma / 2;

            if(media >= 7.0){
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Digite a nota do exame: ");
                exame = float.Parse(Console.ReadLine());

                mediaFinal = (exame + soma) / 2;

                if(mediaFinal >= 5.0){
                    Console.WriteLine("Aprovado!");
                }
                else
                {
                    Console.WriteLine("Reprovado!");
                }
            }

            // EX 6
            string nome;
            float peso, altura, imc;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            altura = float.Parse(Console.ReadLine());

            imc = (altura * altura) / peso;

            if(imc < 18)
            {
                Console.WriteLine("baixo peso");
            }
            if(imc > 18 && imc < 25)
            {
                Console.WriteLine("peso normal");
            }
            if(imc > 25 && imc < 30)
            {
                Console.WriteLine("sobrepeso");
            }
            if(imc > 30 && imc < 35)
            {
                Console.WriteLine("obesidade");
            }
            if(imc > 35)
            {
                Console.WriteLine("obesidade grau serio");
            }
            

            // EX 7
            string frase, palavra;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            Console.WriteLine("Digite uma palavra: ");
            palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra " + palavra + " encontrase na frase");
            }
            else
            {
                Console.WriteLine("A palavra " + palavra + " nao encontrase na frase");
            }
            

            // EX 8
            int codigo, vendas;
            string nome;
            double salario, salarioFinal;

            Console.WriteLine("Codigo do funcionario: ");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do funcionario: ");
            nome = Console.ReadLine();

            Console.WriteLine("Salario do funcionario: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Total de vendas do funcionario: ");
            vendas = int.Parse(Console.ReadLine());

            if(vendas > 500)
            {
                salarioFinal = salario * 0.05;

                Console.WriteLine("Salario final: " + salarioFinal);

            }
            if(vendas > 1000)
            {
                salarioFinal = salario * 0.07;

                Console.WriteLine("Salario final: " + salarioFinal);
            }
            if(vendas > 5000)
            {
                salarioFinal = salario * 0.10;

                Console.WriteLine("Salario final: " + salarioFinal);
            }
            

            // EX 9
            float glicemia1, glicemia2, glicemia3, media;

            Console.WriteLine("digite os seus 3 valores de glicemia em jejum");

            glicemia1 = float.Parse(Console.ReadLine());
            glicemia2 = float.Parse(Console.ReadLine());
            glicemia3 = float.Parse(Console.ReadLine());

            if (glicemia1 < 65 || glicemia2 < 65 || glicemia3 < 65)
            {
                Console.WriteLine("voce corre risco de hipoglicemia");
            }
            else if (glicemia1 > 250 || glicemia2 > 250 || glicemia3 > 250)
            {
                Console.WriteLine("voce corre risco de hiperglicemia");
            }

            media = (glicemia1 + glicemia2 + glicemia3) / 3;

            if (media > 150)
            {
                Console.WriteLine("voce precisa adicionar duas doses de insulina");
            }
            else if (media < 80)
            {
                Console.WriteLine("voce deve diminuir duas doses de insulina");
            }
            

            // EX 10
            string nome1, nome2;
            int idade1, idade2;
            float altura1, altura2;

            Console.WriteLine("Digite o nome do atleta 1: ");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite o nome do atleta 2: ");
            nome2 = Console.ReadLine();

            Console.WriteLine("Digite a idade do atleta 1: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade do atleta 2: ");
            idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do atleta 1: ");
            altura1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do atleta 2: ");
            altura2 = float.Parse(Console.ReadLine());

            
            //dados do atleta mais novo e mais alto

            if(idade1 < idade2)
            {
                Console.WriteLine("Atleta mais novo possui "+idade1+" anos de idade");
            }
            else if(idade2 < idade1)
            {
                Console.WriteLine("Atleta mais novo possui "+idade2+" anos de idade");
            }

            if(altura1 > altura2)
            {
                Console.WriteLine("Atleta mais alto possui " + altura1 + " metros");
            }
            else if(altura2 > altura1)
            {
                Console.WriteLine("Atleta mais alto possui " + altura2 + " metros");
            }
            

            // EX 11
            int hora, minutos;

            Console.WriteLine("Digite a hora: ");
            hora = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os minutos: ");
            minutos = int.Parse(Console.ReadLine());

            if(hora <= 23 && minutos <= 59)
            {
                Console.WriteLine("Horario valido");
            }
            else
            {
                Console.WriteLine("horario invalido");
            }
            

            // EX 12
            int numerohoras, salario, extra;
            string codigo;

            Console.WriteLine("qual seu codigo e quantas horas trabalhou");
            codigo = Console.ReadLine();

            numerohoras = int.Parse(Console.ReadLine());

            if (numerohoras > 50)
            {
                extra = (numerohoras - 50) * 20;
                salario = 10 * 50;
            }
            else
            {
                salario = 10 * numerohoras;
                extra = 0;
            }

            Console.WriteLine("Seu salario eh de: " + salario + "R$ \nSeu valor excedente eh de " + extra + "R$");
            

            // EX 13
            float altura, pesoH, pesoM;

            Console.WriteLine("Digite a altura: ");
            altura = float.Parse(Console.ReadLine());

            pesoH = ((float)(72.7 * altura) - 58);

            pesoM = (float)((62.1 * altura) - 44.7);

            Console.WriteLine("O pesso ideal masculino eh: "+pesoH);

            Console.WriteLine("O peso idela feminino eh: "+pesoM);
            

            // EX 14
            float tam, link, velocidade;

            Console.WriteLine("qual o tamanho do download que quer realizar em mb?");
            tam = float.Parse(Console.ReadLine());

            Console.WriteLine("qual a velocidade do link que usara em mb/h?");
            link = float.Parse(Console.ReadLine());

            velocidade = tam / link * 60;

            Console.WriteLine("ira demorar aproximadamente " + velocidade + " minutos");
            

            // EX 15
            double area, tam, qtdTintas, preco, litros;

            Console.WriteLine("Qual o tamanho da área que deseja pintar em metros quadrados");
            area = float.Parse(Console.ReadLine());

            litros = area / 3;

            qtdTintas = litros / 18;

            qtdTintas = Math.Ceiling(qtdTintas);

            preco = qtdTintas * 80;

            Console.WriteLine("voce precisara de " + qtdTintas + " latas de tinta e gastara " + preco + "R$");
            

            // EX 16
            int timeFora, timeCasa, diferenca;

            Console.WriteLine("qual foi o placar do jogo para o time de fora?");
            timeFora = int.Parse(Console.ReadLine());

            Console.WriteLine("e para o time da casa?");
            timeCasa = int.Parse(Console.ReadLine());

            diferenca = timeFora - timeCasa;

            if (diferenca >= 2)
            {
                Console.WriteLine("O time de fora se classificou");
            }
            

            // EX 17
            int l1, l2, l3;

            Console.WriteLine("Digite os tres lados de um triangulo");
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());
            l3 = int.Parse(Console.ReadLine());

            if (l1 <= (l2 + l3) && l2 <= (l3 + l1) && l3 <= (l1 + l2))
            {
                if (l1 == l2 && l2 == l3)
                {
                    Console.WriteLine("o triangulo eh equilatero");
                }
                else if (l1 != l2 && l1 != l3 && l2 != l3)
                {
                    Console.WriteLine("o triângulo eh escaleno");
                }
                else
                {
                    Console.WriteLine("o triangulo eh isosceles");
                }
            }
            else
            {
                Console.WriteLine("estes valores nao correspondem a um triangulo");
            }
            

            // EX 18
            int v1, v2, v3;

            Console.WriteLine("Digite o valor 1: ");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2: ");
            v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 3: ");
            v3 = int.Parse(Console.ReadLine());

            if(v1 > v2 && v1 > v3)
            {
                Console.WriteLine("Valor 1 maior valor");
            }
            if(v2 > v1 && v2 > v3)
            {
                Console.WriteLine("Valor 2 maior valor");
            }
            if(v3 > v1 && v3 > v2)
            {
                Console.WriteLine("Valor 3 maior valor");
            }
            


            // EX 19
            float num1, num2, num3, prim, seg, terc;

            Console.WriteLine("Escreva tres valores");
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
            num3 = float.Parse(Console.ReadLine());

            if (num1 > num3 && num1 > num2)
            {
                terc = num1;
            }
            else if (num2 > num3 && num2 > num1)
            {
                terc = num2;
            }
            else
            {
                terc = num3;
            }
            if (num1 > num2 && num1 < num3 || num1 > num3 && num1 < num2)
            {
                seg = num1;
            }
            else if (num2 > num1 && num2 < num3 || num2 > num3 && num2 < num1)
            {
                seg = num2;
            }
            else
            {
                seg = num3;
            }
            if (num1 < num2 && num1 < num3)
            {
                prim = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                prim = num2;
            }
            else
            {
                prim = num3;
            }

            Console.WriteLine("ORDEM CRESCENTE DOS NUMEROS");
            Console.WriteLine(prim + "\n" + seg + "\n" + terc);
            

            // EX 20
            int numero_aleatorio = 30, chute;

            Console.WriteLine("tente acertar o numero");

            for (int i = 0; i > 3; i++)
            {
                chute = int.Parse(Console.ReadLine());
                if (chute == numero_aleatorio)
                {
                    Console.WriteLine("parabens, voce acertou");
                    break;
                }
                else if (chute < numero_aleatorio)
                {
                    Console.WriteLine("eh maior");

                }
                else
                {
                    Console.WriteLine("eh menor");

                }
            }

        }
    }
}
