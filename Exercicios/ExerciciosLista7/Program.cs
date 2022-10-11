namespace ExerciciosLista7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //EX 1
            string titulo;
            string autor;
            int numeroPaginas;

            Console.WriteLine("Digite o titulo do livro: ");
            titulo = Console.ReadLine();

            Console.WriteLine("Digite o autor do livro: ");
            autor = Console.ReadLine();

            Console.WriteLine("Digite o numero de paginas do livro: ");
            numeroPaginas = int.Parse(Console.ReadLine());

            //EX 2
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

            Carro carro;
            Cliente cliente;
            Aluguel aluguel;

            Console.WriteLine("Escreva o nome e idade do cliente");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a idade do cliente?");
            int id = int.Parse(Console.ReadLine());

            cliente = new Cliente(nome);

            Console.WriteLine("Qual modelo de carro que sera alugado?");
            string modelo = Console.ReadLine();

            Console.WriteLine("Qual sera a placa do carro?");
            string placa = Console.ReadLine();

            carro = new Carro(modelo, placa);

            Console.WriteLine("Qual sera o valor do aluguel deste carro?");
            double aluguel1 = double.Parse(Console.ReadLine());

            aluguel = new Aluguel(cliente, aluguel1, carro);

            aluguel.mostrarDados();


            // EX 4      
            pessoa pessoaFilho = new pessoa();
            pessoaFilho.nome = "Diego";

            pessoa pessoaMae = new pessoa();
            pessoaMae.nome = "Erika";

            pessoa pessoaPai = new pessoa();
            pessoaPai.nome = "Sergio";

            pessoa pAvoPai = new pessoa();
            pAvoPai.nome = "João";

            pessoaPai.pai = pAvoPai;

            pessoaFilho.mae = pessoaMae;

            pessoaFilho.pai = pessoaPai;


            // EX 5
            Produto produto = new Produto();

            Itens item;

            Cliente cliente = new Cliente();

            produto.QtdProduto = 60;
            produto.Preco = 5;

            Console.WriteLine("Qual o nome do cliente?");
            cliente.nome = Console.ReadLine();

            Console.WriteLine("Qual o cpf do cliente?");
            cliente.cpf = Console.ReadLine();

            Console.WriteLine("Que produto esta comprando?");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Qual a quantidade que deseja comprar ?");
            item = new Itens();

            item.Produto = produto;

            item.setQuantidade(int.Parse(Console.ReadLine()));

            Pedido pedido = new Pedido(item, cliente);

            pedido.setValor();

            Console.WriteLine("valor = R$" + pedido.getValor());

            // EX 6
            int op;
            Agenda e = new Agenda("Agenda do Centro");
            string nome;
            int idade;
            float altura;
            Pessoa consulta = null;
            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar pessoa\nDigite 2 para buscar as informações \nDigite 3 para apagar pessoa\nDigite 4 para sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Digite o nome da pessoa: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Digite a idade da pessoa: ");
                    idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a altura da pessoa: ");
                    altura = float.Parse(Console.ReadLine());

                    e.ArmazenaPessoa(nome, idade, altura);
                    /*e.ArmazenaCarro("VW", "Fusca", "ABC-1234");
                    e.ArmazenaCarro("Ford", "Belina", "IEJ8115");*/
                    Console.Clear();
                    e.MostraPessoas();
                }
                if (op == 2)
                {
                    Console.WriteLine("Digite o nome da pessoa que deseja buscar: ");
                    nome = Console.ReadLine();
                    consulta = e.BuscaPessoa(nome);
                    if (consulta != null)
                    {
                        Console.WriteLine("Pessoa ENCONTRADA! Nome: " + consulta.nome + " idade " + consulta.idade);

                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrado!");
                    }
                }
                if (op == 3)
                {
                    Console.WriteLine("Digite o nome da pessoa que sairá: ");
                    nome = Console.ReadLine();
                }
                if (op == 4)
                {
                    break;
                }
            }


            // EX 8
            Televisao tv = new Televisao();
            ControleRemoto controle = new ControleRemoto();
            tv.Controle = controle;
            tv.Volume = 20;
            tv.Canal = 0;
            int num = 0;
            while (num != 5)
            {
                Console.WriteLine("1-aumentar volume\n2- baixar volume\n3-trocar de canal\n4-Consultar canal e volume\n5-Sair");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        tv.Volume = tv.Controle.aumentar_volume(tv.Volume);
                        break;
                    case 2:
                        tv.Volume = tv.Controle.abaixar_volume(tv.Volume);
                        break;
                    case 3:
                        tv.Canal = tv.Controle.trocar_canal();
                        break;
                    case 4:
                        tv.Controle.consultarCanalEVolume(tv.Canal, tv.Volume);
                        break;
                    default:
                        break;
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                }
            }







        }

    }
    }
