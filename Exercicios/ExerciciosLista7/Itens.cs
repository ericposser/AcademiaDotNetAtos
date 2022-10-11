using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista7
{
    internal class Itens
    {
        private Produto produto;
        private int quantidade;

        public int Quantidade { get => quantidade; set => quantidade = value; }
        internal Produto Produto { get => produto; set => produto = value; }

        public void setQuantidade(int qtd)
        {
            do
            {
                if (qtd > Produto.QtdProduto)
                {
                    Console.WriteLine("não possuimos esta quantidade de produto");
                }
                else
                {
                    Quantidade = qtd;
                    break;
                }
                Console.WriteLine("Digite uma nova quantia");
                qtd = int.Parse(Console.ReadLine());
            } while (true);

        }
    }
}
