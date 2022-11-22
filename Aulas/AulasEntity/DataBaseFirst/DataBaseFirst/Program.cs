using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite: \n" + "1 para criar uma pessoa \n" + "2 para alterar o nome da pessoa\n" + "3 para inserir um email \n" + "4 para excluir uma pessoa\n" + "5 para consultar tudo\n" + "6 para consultar pelo ID \n");

            int op = int.Parse(Console.ReadLine());

            AtosEntity2Context contexto = new AtosEntity2Context();

            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Inserir o nome da pessoa:");
                        Pessoa p = new Pessoa();
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("Informe um email:");
                        string emailTemp = Console.ReadLine();
                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };
                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();
                        Console.WriteLine("Pessoa inserida com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }        
                    break;

                case 2:
                    try
                    {
                        Console.WriteLine("informe o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pAlt = contexto.Pessoas.Find(id);

                        Console.WriteLine("informe o nome correto: ");
                        pAlt.Nome = Console.ReadLine();

                        contexto.Update(pAlt);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                    break;

                case 3:
                    try
                    {
                        Console.WriteLine("informe o id da pessoa: ");
                        int idEm = int.Parse(Console.ReadLine());

                        Pessoa pEm = contexto.Pessoas.Find(idEm);

                        Console.WriteLine("informe novo email: ");
                        string emailTemp = Console.ReadLine();

                        pEm.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        contexto.Update(pEm);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 4:
                    try
                    {
                        Console.WriteLine("informe o id da pessoa: ");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Confirmar a exclusão de: " + p.Nome);
                        Console.WriteLine("e dos seus emails:");

                        foreach (Email item in p.Emails)
                        {
                            Console.WriteLine("\t" + item.email);
                        }

                        Console.WriteLine("1 para sim e 2 para nao");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine(p.Nome + " excluida com sucesso!");
                        }
                        else
                        {
                            return;
                        }

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 5:
                    try
                    {
                        List<Pessoa> lista = new List<Pessoa>();

                        lista = (from Pessoa p in contexto.Pessoas select p).Include(pes => pes.Emails).ToList<Pessoa>();

                        foreach (Pessoa item in lista)
                        {
                            Console.WriteLine(item.Nome);

                            foreach (Email itemE in item.Emails)
                            {
                                Console.WriteLine("\t" + itemE.email);
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 6:
                    try
                    {
                        Console.WriteLine("informe o id da pessoa: ");
                        int idFiltro = int.Parse(Console.ReadLine());

                        Pessoa p = contexto.Pessoas.Include(pes => pes.Emails).FirstOrDefault(pessoa => pessoa.Id == idFiltro);

                        Console.WriteLine("Nome: " + p.Nome);

                        if (p.Emails != null)
                        {
                            foreach (Email item in p.Emails)
                            {
                                Console.WriteLine("\t" + item.email);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;

                default:
                    break;
            }
        }
    }
}