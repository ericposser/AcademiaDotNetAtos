namespace Listaa6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EX 1
            //criando a lista
            List<string> nomes = new List<string>();

            //variaveis
            string nome;
            int i;

            //cadastrando nome
            do
            {
                Console.WriteLine("Digite um nome ou 'sair': ");
                nome = Console.ReadLine().ToUpper();

                if (nome == "SAIR")
                {
                    break;
                }

                if (nomes.Contains(nome) || !nome.Contains(" "))
                {
                    Console.WriteLine("Nome já cadastrado ou nome sem sobrenome!!");
                }
                else
                {
                    nomes.Add(nome);
                }

            } while (true);

            Console.WriteLine("-------------------------");

            //mostrando nomes na tela
            nomes.Sort();
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }


            // EX 2
            Random gerador = new Random();

            List<int> lista = new List<int>();

            int qtdNumeros, num;

            Console.WriteLine("Quantos números deseja armnazenar na lista?");
            qtdNumeros = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdNumeros; i++)
            {
                num = gerador.Next(0, 1000);
                lista.Add(num);
            }
            Console.WriteLine("-----------Numeros da lista-----------");
            for (int i = 0; i < qtdNumeros; i++)
            {
                Console.WriteLine(lista[i]);
            }

            // EX 3
            List<string> emails = new List<string>();

            int opcao;
            string email;

            do
            {

                Console.WriteLine("MENU");
                Console.WriteLine("1 - cadastrar email");
                Console.WriteLine("2 - listar email");
                Console.WriteLine("3 - sair");
                Console.WriteLine("opcao: ");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();


                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Digite o email: ");
                        email = Console.ReadLine().ToUpper();


                        if (emails.Contains(email))
                        {
                            Console.WriteLine("email já cadastrado");
                        }
                        else
                        {
                            emails.Add(email);
                        }

                        break;

                    case 2:


                        emails.Sort();
                        foreach (var item in emails)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("--Listando dominios--");

                        string[] dadosEmail = email.Split("@");
                        Console.WriteLine("dominio: " + dadosEmail[1]);

                        break;

                    case 3:
                        break;
                }
                Console.WriteLine("Pressione enter para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 3);

            // EX 4
            List<string> listaCripto = new List<string>();
            int opcao;
            string cripto;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - cadastrar criptomoeda");
                Console.WriteLine("2 - listar criptomoeda");
                Console.WriteLine("3 - remover criptomoeda");
                Console.WriteLine("4 - sair");
                Console.WriteLine("opcao: ");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Digite um nome da criptomoeda: ");
                        cripto = Console.ReadLine().ToUpper();

                        if (listaCripto.Contains(cripto))
                        {
                            Console.WriteLine("Moeda já cadastrada");
                        }
                        else
                        {
                            listaCripto.Add(cripto);
                        }

                        break;

                    case 2:
                        listaCripto.Sort();
                        foreach (var item in listaCripto)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Qual moeda deseja remover?");
                        cripto = Console.ReadLine().ToUpper();

                        if (listaCripto.Contains(cripto))
                        {
                            listaCripto.Remove(cripto);
                            Console.WriteLine("Moeda removida");
                        }
                        else
                        {
                            Console.WriteLine("Esta moeda não esta cadastrada");
                        }

                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Opcao invalida");
                        break;

                }

                Console.WriteLine("Pressione enter para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcao != 4);


            // EX 5
            Random gerador = new Random();
            List<int> lista1 = new List<int>(), lista2 = new List<int>();
            int qtdNumeros, num;

            Console.WriteLine("Quantos números deseja armnazenar na lista 1?");
            qtdNumeros = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdNumeros; i++)
            {
                num = gerador.Next(100, 200);
                lista1.Add(num);
            }
            Console.WriteLine("Quantos números deseja armnazenar na lista 2?");
            qtdNumeros = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdNumeros; i++)
            {
                num = gerador.Next(100, 200);
                lista2.Add(num);
            }
            Console.WriteLine("-----------Numeros da lista 1-----------");
            for (int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine(lista1[i]);
            }
            Console.WriteLine("-----------Numeros da lista 2-----------");
            for (int i = 0; i < lista2.Count; i++)
            {
                Console.WriteLine(lista2[i]);
            }
            Console.WriteLine("-----------Numeros em comum em ambas as listas-----------");
            if (lista1.Count > lista2.Count)
            {
                for (int i = 0; i < lista1.Count; i++)
                {
                    for (int j = 0; j < lista2.Count; j++)
                    {
                        if (lista1[i] == lista2[j])
                        {
                            Console.WriteLine(lista1[i]);
                            break;
                        }
                    }
                }
            }
            else if (lista2.Count > lista1.Count)
            {
                for (int i = 0; i < lista2.Count; i++)
                {
                    for (int j = 0; j < lista1.Count; j++)
                    {
                        if (lista1[j] == lista2[i])
                        {
                            Console.WriteLine(lista2[i]);
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < lista1.Count; i++)
                {
                    for (int j = 0; j < lista2.Count; j++)
                    {
                        if (lista1[i] == lista2[j])
                        {
                            Console.WriteLine(lista1[i]);
                        }
                    }
                }
            }


            // EX 6
            string nome;
            List<string> nomePessoas = new List<string>();
            string[] sobrenome, sobrenome2;

            do
            {
                Console.WriteLine("Digite um nome");
                nome = Console.ReadLine().ToUpper();
                if (nome == "SAIR")
                {
                    break;
                }
                if (nomePessoas.Contains(nome))
                {
                    Console.WriteLine("Nome ja cadastrado");
                    continue;
                }
                if (!nome.Contains(" "))
                {
                    Console.WriteLine("Deve haver no minimo duas palavras");
                    continue;
                }
                else
                {
                    nomePessoas.Add(nome);
                }
            } while (true);
            nomePessoas.Sort();
            Console.WriteLine("-------------Mostrando sobrenomes-------------");
            for (int i = 0; i < nomePessoas.Count; i++)
            {
                sobrenome = nomePessoas[i].Split(" ");
                Console.WriteLine(sobrenome[1]);
            }
            for (int i = 0; i < nomePessoas.Count; i++)
            {
                for (int j = 0; j < nomePessoas.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    sobrenome = nomePessoas[i].Split(" ");
                    sobrenome2 = nomePessoas[j].Split(" ");
                    if (sobrenome[1] == sobrenome2[1])
                    {
                        Console.WriteLine(nomePessoas[i] + " é da mesma familia de " + nomePessoas[j]);
                    }
                }
            }

        }
    }
}