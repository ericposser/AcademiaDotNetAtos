using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Desafio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aqui estou fazendo tal coisa
            //iniciando listas
            List<Pessoa> listaPessoas = new List<Pessoa>();
            List<Pessoa> listaCursos = new List<Pessoa>();

            //variaveis
            int qtdPessoa = 0;
            int qtdAlunos = 0;
            string linha;
            string[] dadosLinha;
            bool confirmaPessoa = false;
            Pessoa pessoa;
            Aluno aluno;

            //iniciando leitor do arquivo
            StreamReader leitor = new StreamReader(@"C:\Users\eric_\OneDrive\Área de Trabalho\Dados.txt");

            do //lendo o arquivo
            {

                linha = leitor.ReadLine();
                dadosLinha = linha.Split("-");
                string letra = dadosLinha[0];
                pessoa = new Pessoa(); //iniciando lista pessoas
                aluno = new Aluno(); //iniciando listas alunos


                if (letra == "X") //lendo o cabeçalho
                {

                }
                else if (letra == "Z") //lendo a classe pessoa
                {
                    pessoa.nome = dadosLinha[1];
                    pessoa.telefone = dadosLinha[2];
                    pessoa.cidade = dadosLinha[3];
                    pessoa.rg = dadosLinha[4];
                    pessoa.cpf = dadosLinha[5];
                    qtdPessoa++;
                    confirmaPessoa = true;
                }
                else if (letra == "Y") //lendo a classe aluno
                {
                    aluno.matricula = dadosLinha[1];
                    aluno.codigo = dadosLinha[2];
                    aluno.nomeCurso = dadosLinha[3];

                    if (confirmaPessoa)
                    {
                        qtdPessoa--;
                        qtdAlunos++;
                    }
                }

                //adicionando a lista
                listaCursos.Add(aluno);
                listaPessoas.Add(pessoa);

                //mostrando na tela as pessoas
                if (letra == "Z")
                {
                    Console.WriteLine("Nome: " + pessoa.nome + " Telefone: " + pessoa.telefone + " Cidade: " + pessoa.cidade + " RG: " + pessoa.rg + " CPF: " + pessoa.cpf);

                }

                //mostrando na tela as pessoas com seus cursos(alunos)
                if (letra == "Y")
                {
                    Console.WriteLine("Matricula: " + aluno.matricula + " Codigo: " + aluno.codigo + " Nome do curso: " + aluno.nomeCurso + "\n");
                }

            } while (!leitor.EndOfStream);


            leitor.Close();

            //quantidade de pessoas e alunos
            Console.WriteLine("\n" + "Quantidade de pessoas: " + qtdPessoa);
            Console.WriteLine("Quantidade de alunos: " + qtdAlunos);

        }
    }
}


