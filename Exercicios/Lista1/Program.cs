using System.Net.Http.Headers;
using System.Runtime.Serialization;

namespace PrimeiraAplicação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* EX 1
            int n1, n2, soma, media;

            Console.WriteLine("Digite a nota 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;
            media = soma / 2;

            Console.WriteLine("A media eh: " + media);
            */


            /* EXERCICIO 2
            int n1, n2, n3, n4, soma, media;

            Console.WriteLine("Digite a nota 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 3: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 4: ");
            n4 = int.Parse(Console.ReadLine());

            soma = n1 + n2 + n3 + n4;
            media = soma / 4;

            Console.WriteLine("A media eh: " + media);
            */

            /* EXERCICIO 3
            int a, b, temp;

            Console.WriteLine("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());


            temp = a;
            a = b;
            b = temp;
            
            Console.WriteLine("O valor de A vale: " + a + " O valor de B vale: " + b);
            */

            /* EXERCICIO 4
            int dia, mes, ano;

            Console.WriteLine("Escreva o dia (DD): ");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o mes (MM): ");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o ano (AAAA): ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Data: " + ano + mes + dia + "e: " + ano + mes + dia);

            Console.WriteLine("Data: " + ano + mes + dia + "e: " + ano % 100 + mes + dia);
            */

            //EX 5

            /* EXERCICIO 6
            Console.WriteLine("Informe o código do parafuso A");
            int codA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de parafusos A");
            int quantA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do parafuso A");
            double valorA = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código do parafuso B");
            int codB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de parafusos B");
            int quantB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do parafuso B");
            double valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual do IPI");
            double ipi = double.Parse(Console.ReadLine());

            double totalA, totalB;

            totalA = (quantA * valorA);
            totalA = totalA + (totalA * (ipi / 100));

            totalB = quantB * valorB;
            totalB = totalB + (totalB * (ipi/100));

            Console.WriteLine("Custo total dos parafusos A:" + totalA);
            Console.WriteLine("Custo total dos parafusos B:" + totalB);
            */

            //EX 7

            /* EXERCICIO 8
            int temperatura, f;

            Console.WriteLine("Digite a temperatura em C: ");
            temperatura = int.Parse(Console.ReadLine());

            f = (9 * temperatura + 160) / 5;

            Console.WriteLine("Temperatura convertida: " + f);
            */

            /* EX 9
            Console.WriteLine("Informe o valor da mercadoria");
            double mercadoria = double.Parse(Console.ReadLine());

            double prestacao = 0;

            double resto = mercadoria % 3;
            mercadoria = mercadoria - resto;

            prestacao = mercadoria / 3;

            double entrada = prestacao + resto;

            Console.WriteLine("entrade de " + entrada + " e 2x de " + prestacao);
            */

            /* EX 10
            double saque = 0;

            int total200 = 0, total100 = 0, total50 = 0, total20 = 0, total10 = 0, total5 = 0, total2 = 0, total1 = 0;

            Console.WriteLine("Informar o valor do saque:");
            saque = double.Parse(Console.ReadLine());

            total200 = (int)(saque / 200);
            Console.WriteLine("Notas de 200: " + total200);
            saque = saque - (200 * total200);

            total100 = (int)(saque / 100);
            Console.WriteLine("Notas de 100: " + total100);
            saque = saque - (100 * total100);

            total50 = (int)(saque / 50);
            Console.WriteLine("Notas de 50: " + total50);
            saque = saque - (50 * total50);

            total20 = (int)(saque / 20);
            Console.WriteLine("Notas de 20: " + total20);
            saque = saque - (20 * total20);

            total10 = (int)(saque / 10);
            Console.WriteLine("Notas de 10: " + total10);
            saque = saque - (10 * total10);

            total5 = (int)(saque / 5);
            Console.WriteLine("Notas de 5: " + total5);
            saque = saque - (5 * total5);

            total2 = (int)(saque / 2);
            Console.WriteLine("Notas de 2: " + total2);
            saque = saque - (2 * total2);

            total1 = (int)(saque / 1);
            Console.WriteLine("Notas de 1: " + total1);
            saque = saque - (1 * total1);
            */

            // EX 11

            /* EXERCICIO 12
            int marcacaoInicio, marcacaoFinal, litros, totalkm, media;
            float valor, lucro;

            Console.WriteLine("Digite marcação do odometro no inicio do dia: ");
            marcacaoInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite marcação do odometro no final do dia: ");
            marcacaoFinal = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de litros de combustivel gasto: ");
            litros = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor total ");
            valor = float.Parse(Console.ReadLine());

            totalkm = marcacaoFinal - marcacaoInicio;

            media = totalkm / litros;

            lucro = (float)(valor - (litros * 6.90));

            Console.WriteLine("A media do consumo foi: " + media + " e o lucro do dia foi: " + lucro);
            */

            /* EX 13
            double salarioMin = 0;
            double comissao = 0, custo = 0;
            int quantidade = 0;

            Console.WriteLine("Informe o salário mínimo atual:");
            salarioMin = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço de custo da bike:");
            custo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de bikes vendidas:");
            quantidade = int.Parse(Console.ReadLine());

            double venda = custo + (custo * 0.5);
            comissao = (quantidade * venda) * 0.15;
            double salario = (salarioMin * 2) + comissao;

            Console.WriteLine("O salário resultou em: " + salario);
            */
        }
    }
}