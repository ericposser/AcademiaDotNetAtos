using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista7
{
    internal class Produto
    {
        private int qtdProduto;
        private string nome;
        private float preco;

        public int QtdProduto { get => qtdProduto; set => qtdProduto = value; }
        public string Nome { get => nome; set => nome = value; }
        public float Preco { get => preco; set => preco = value; }
    }
}
