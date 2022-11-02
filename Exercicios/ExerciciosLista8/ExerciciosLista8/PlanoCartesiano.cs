using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista8
{
    internal class PlanoCartesiano
    {
        private float _X;
        private float _Y;

        public PlanoCartesiano(float x, float y)
        {
            _X = x;
            _Y = y;
        }

        public float X
        {
            get { return _X; }
            set { _X = value; }
        }

        public float Y
        {
            get { return _Y; }
            set { _Y = value; }
        }

        public void MostrarObjetos()
        {
            Console.WriteLine("Posição x: " + _X + " Posição y: " + _Y);
        }

    }
}
