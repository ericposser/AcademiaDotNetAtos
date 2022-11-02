using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista8
{
    internal class Livro
    {
        private string _Nome;
        private int _QtdPaginas;

        public Livro(string nome, int qtdPaginas)
        {
            _Nome = nome;
            _QtdPaginas = qtdPaginas;
        }

        public string Nome { get => _Nome; set => _Nome = value; }
        public int QtdPaginas { get => _QtdPaginas; set => _QtdPaginas = value; }
    }
}
