using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio7
{
    internal class livro
    {
        private string titulo;
        private string autor;
        private int numeroPaginas;
        public livro(string titulo, string autor, int numeroPaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.numeroPaginas = numeroPaginas;
        }
    }

}
