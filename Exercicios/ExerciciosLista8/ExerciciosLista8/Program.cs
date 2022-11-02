namespace ExerciciosLista8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EX 1
            int persons = 0, opc = 0;

            List<Personagem> person = new List<Personagem>();

            while (persons < 3)
            {
                Console.WriteLine("\n== Bem vindo ao sistema de personagens ===");
                Console.WriteLine("1 - Cadastrar Personagem");
                Console.WriteLine("2 - Listar Personagens");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha sua opção: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Write("\nInforme o nome do personagem: ");
                        string nome = Console.ReadLine();
                        int poder;
                        do
                        {
                            Console.Write("Informe o poder do personagem '{0}': ", nome);
                            poder = int.Parse(Console.ReadLine());
                            if (poder < 0)
                            {
                                Console.WriteLine("Poder inválido. Valor mínimo: 0\n");
                            }
                            else if (poder > 10)
                            {
                                Console.WriteLine("Poder inválido. Valor máximo: 10\n");
                            }
                        } while (poder < 0 && poder > 10);
                        person.Add(new Personagem(nome, poder));
                        persons++;
                        break;
                    case 2:
                        Personagem.MaisPoderoso(person);
                        break;
                    case 3:
                        persons = 3;
                        break;
                }
            }
            Personagem.MaisPoderoso(person);


            // EX 2
            string nome, tipo;
            int quant = 0, tp;

            List<Animal> animal = new List<Animal>();

            while (quant < 5)
            {
                Console.Clear();
                Console.Write("Informe o nome do animal: ");
                nome = Console.ReadLine();
                do
                {
                    Console.WriteLine("Informe o tipo do animal: ");
                    Console.WriteLine("1 - Cachorro");
                    Console.WriteLine("2 - Gato");
                    Console.WriteLine("3 - Peixe");
                    Console.Write("\nSua escolha: ");
                    tp = int.Parse(Console.ReadLine());
                    switch (tp)
                    {
                        case 1:
                            tipo = "Cachorro";
                            break;
                        case 2:
                            tipo = "Gato";
                            break;
                        case 3:
                            tipo = "Peixe";
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            tipo = "inválido";
                            break;
                    }
                } while (tipo != "Cachorro" && tipo != "Gato" && tipo != "Peixe");
                animal.Add(new Animal(nome, tipo));
                quant++;
            }
            Console.Clear();
            Animal.ExibeAnimais(animal);

            //EX 3
            List<Asteroide> asteroides = new List<Asteroide>();

            void MostrarAsteroides()
            {
                int c = 0;
                Console.WriteLine("Lista de asteróides");
                asteroides.ForEach(delegate (Asteroide item)
                {
                    Console.WriteLine("Asteroide" + c + "=\nPosição x: " + item.GetPosicaoX() + "\nPosição y: " + item.GetPosicaoY() + "\nTamanho: " + item.GetTam() + "\nVelocidade: " + item.GetVelocidade() + "\nEnergia: " + item.GetEnergia());
                    c++;
                    Console.WriteLine();
                    Console.WriteLine();
                });
            }
            int num, velocidade, energia, posicaoY, posicaoX, tam;
            Asteroide a = new Asteroide();
            do
            {
                Console.WriteLine("1-Criar novo asteróide\n2-Sair");
                num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("Qual a posição x do asteroide?");
                    posicaoX = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a posição y do asteroide");
                    posicaoY = int.Parse((string)Console.ReadLine());
                    do
                    {
                        Console.WriteLine("Qual o tamanho do asteroide( 1 a 10)");
                        tam = int.Parse(Console.ReadLine());
                    } while (!a.SetTam(tam));
                    do
                    {
                        Console.WriteLine("Qual a velocidade do asteróide?(1 a 5)");
                        velocidade = int.Parse(Console.ReadLine());
                    } while (!a.SetVelocidade(velocidade));
                    do
                    {
                        Console.WriteLine("Qual a energia do asteroide?(1 a 5)");
                        energia = int.Parse(Console.ReadLine());
                    } while (!a.SetEnergia(energia));
                    asteroides.Add(new Asteroide(posicaoX, posicaoY, tam, velocidade, energia));
                }
                else
                {
                    break;
                }
            } while (true);
            MostrarAsteroides();

            //EX 4
            Item item;

            float altura;
            string descricao;
            DateTime data;

            Console.WriteLine("Qual a descricao do item?");
            descricao = Console.ReadLine();

            Console.WriteLine("Qual a altura do item que deseja criar?");
            altura = float.Parse(Console.ReadLine());

            data = DateTime.Now;

            item = new Item(descricao, data, altura);

            item.MostrarItens(item);

            item.TempoDeCriacao(item);

            //EX 5
            List<PlanoCartesiano> objetos = new List<PlanoCartesiano>();
            int op, x, y;
            void Mostrarobjetos()
            {
                for (int i = 0; i < objetos.Count; i++)
                {
                    Console.WriteLine("Indice: " + i + " X: " + objetos[i].X + " Y: " + objetos[i].Y);
                }
            }
            Console.WriteLine("Cadastrando objetos num plano cartesiano");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Pressione 1 para cadastrar objeto ou qualquer outro número para sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Qual a posição X e Y do objeto?");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                    objetos.Add(new PlanoCartesiano(x, y));
                    Console.WriteLine("Presione enter para continuar.....");
                    Console.ReadKey();
                }
                else { break; }
            }
            Mostrarobjetos();

            //EX 6
            List<Funcionario> funcionarios = new List<Funcionario>();

            int op, i;
            string nome;
            string departamento;
            double salario;
            string dataEntrada;
            string rg;
            bool ativo;
            int num;
            double bonus;

            bool LocalizarNome(string nome, List<Funcionario> lista)
            {
                foreach (var funcionario in lista)
                {
                    if (funcionario.Nome == nome) { return true; }
                }
                return false;
            }
            int LocalizarIndice(string nome, List<Funcionario> lista)
            {
                int ind = 0;
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Nome == nome)
                    {
                        ind = i;
                    }
                }
                return ind;
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------Menu de gerenciamento de funcionários--------");
                Console.WriteLine("O que deseja fazer?\n1-Cadastrar Funcionario\n2-Bonificar algum funcionário\n3-Exibir lista de funcionários ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("CADASTRANDO FUNCIONÁRIO");
                        Console.WriteLine("Qual o nome do funcionário?");
                        nome = Console.ReadLine();

                        Console.WriteLine("Qual o seu departamento?");
                        departamento = Console.ReadLine();

                        Console.WriteLine("Qual o salário?");
                        salario = double.Parse(Console.ReadLine());

                        Console.WriteLine("Qual a sua data de entrada na emprese?[dd/mm/aaaa]");
                        dataEntrada = Console.ReadLine();

                        Console.WriteLine("Qual seu RG?");
                        rg = Console.ReadLine();

                        Console.WriteLine("O funcionario ainda esta ativo na emprese?(1 para sim e 2 para não)");
                        num = int.Parse(Console.ReadLine());

                        if (num == 1)
                        {
                            ativo = true;
                        }
                        else
                        {
                            ativo = false;
                        }
                        Console.WriteLine("Qual a sua função na empresa?(1 para operário e 2 para gerente)");
                        num = int.Parse(Console.ReadLine());
                        if (num == 1)
                        {
                            funcionarios.Add(new Operario(nome, departamento, salario, dataEntrada, rg, ativo));
                            Console.WriteLine("Operario adicionado na lista");
                        }
                        else
                        {
                            funcionarios.Add(new Gerente(nome, departamento, salario, dataEntrada, rg, ativo));
                            Console.WriteLine("Gerente adicionado na lista");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Qual o nome do funcionario que deseja bonificar?");
                        nome = Console.ReadLine();
                        if (LocalizarNome(nome, funcionarios))
                        {
                            i = LocalizarIndice(nome, funcionarios);
                            Console.WriteLine("Escreva o valor do bonus do funcionario");
                            bonus = double.Parse(Console.ReadLine());
                            funcionarios[i].Bonifica(bonus);
                            Console.WriteLine("Novo salario do funcionario = R$" + funcionarios[i].Salario);
                        }
                        else
                        {
                            Console.WriteLine("Funcionario não localizado");

                        }
                        break;
                    case 3:
                        if (funcionarios.Count == 0)
                        {
                            Console.WriteLine("Ainda não há ninguem na lista");
                        }
                        else
                        {
                            foreach (var funcionario in funcionarios)
                            {
                                Console.WriteLine("------------" + "\nNome: " + funcionario.Nome + "\nRG: " + funcionario.RG + "\nDepartamento: " + funcionario.Departamento + "\nData de entrada: " + funcionario.DataEntrada + "\nSalário: R$" + funcionario.Salario);
                                funcionario.MostrarAtividade();
                                funcionario.Funcao();
                            };

                        }
                        break;

                }

                Console.ReadKey();

                //EX 7
                Dictionary<string, Livro> dic = new Dictionary<string, Livro>();
            int op, qtdPaginas;
            string nome;
            Livro aux;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite 1 para cadastrar livro, 2 para consultar os livros cadastrados, 3 para pesquisar livro pelo nome, 4 para sair");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("Qual o nome do livro?");
                    nome = Console.ReadLine();
                    Console.WriteLine("Qual o número de paginas do livro?");
                    qtdPaginas = int.Parse(Console.ReadLine());
                    dic.Add(nome, new Livro(nome, qtdPaginas));
                }
                else if (op == 2)
                {
                    foreach (KeyValuePair<string, Livro> item in dic)
                    {
                        Console.WriteLine("-------------------\nNome: " + item.Value.Nome + " Quantidade de paginas:" + item.Value.QtdPaginas);
                    }
                }
                else if (op == 3)
                {
                    Console.WriteLine("Que livro deseja pesquisar?");
                    nome = Console.ReadLine();
                    if (dic.ContainsKey(nome))
                    {
                        dic.TryGetValue(nome, out aux);
                        Console.WriteLine("Nome: " + aux.Nome + " Quantidade de páginas: " + aux.QtdPaginas);
                    }
                }
                else { break; }
                Console.ReadLine();

            }
        }
    }
}