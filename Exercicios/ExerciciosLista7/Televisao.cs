using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista7
{
    internal class Televisao
    {
        private int volume;
        private int canal;
        private ControleRemoto controle;

        public int Volume { get => volume; set => volume = value; }
        public int Canal { get => canal; set => canal = value; }
        internal ControleRemoto Controle { get => controle; set => controle = value; }
    }
}
