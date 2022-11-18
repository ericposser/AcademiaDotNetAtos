using System;
using System.IO;

namespace AulaArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome");
            string nome = Console.ReadLine();

        
            List<string> linhas = new List<string>();

            if (File.Exists(@"C:\Users\eric_\OneDrive\Área de Trabalho\arqu.txt"))
            {
                StreamReader reader = new StreamReader(@"C:\Users\eric_\OneDrive\Área de Trabalho\exercicio.txt");


                linhas.Add(reader.ReadLine());

                string linha = "";

                while (linha != null)
                {
                    linha = reader.ReadLine();

                    if (linha != null)
                        linhas.Add(linha);
                }

                reader.Close();

            }

            linhas.Add(nome);

            StreamWriter writer = new StreamWriter(@"C:\Users\eric_\OneDrive\Área de Trabalho\ar.txt");

            foreach (string item in linhas)
            {
                writer.WriteLine(item);
            }

            writer.Close();


        }
    }
}