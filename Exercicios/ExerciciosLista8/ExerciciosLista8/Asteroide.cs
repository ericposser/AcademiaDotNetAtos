using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista8
{
    internal class Asteroide
    {
        private int _PosicaoX;
        private int _PosicaoY;
        private int _Tam;
        private int _Velocidade;
        private int _Energia;

        public Asteroide(int posicaoX, int posicaoY, int tam, int velocidade, int energia)
        {
            _PosicaoX = posicaoX;
            _PosicaoY = posicaoY;
            _Tam = tam;
            _Velocidade = velocidade;
            _Energia = energia;
        }

        public Asteroide(int posicaoX, int posicaoY)
        {
            _PosicaoX = posicaoX;
            _PosicaoY = posicaoY;
        }

        public Asteroide()
        {
        }

        public void SetPosicaoX(int posicao)
        {
            posicao = _PosicaoX;
        }
        public void SetPosicaoy(int posicao)
        {
            posicao = _PosicaoY;
        }
        public bool SetTam(int tam)
        {
            if (tam >= 1 && tam <= 10)
            {
                _Tam = tam;
                return true;
            }
            else
            {
                Console.WriteLine("O valor do tamanho deve ser maior que 0 e menor que 11");
                return false;
            }
        }
        public bool SetVelocidade(int vel)
        {
            if (vel >= 1 && vel <= 5)
            {
                _Velocidade = vel;
                return true;
            }
            else
            {
                Console.WriteLine("O valor da velocidade deve ser maior que 0 e menor que 6");
                return false;
            }
        }

        public bool SetEnergia(int energia)
        {
            if (energia >= 1 && energia <= 5)
            {
                _Energia = energia;
                return true;
            }
            else
            {

                Console.WriteLine("O valor da energia deve ser maior que 0 e menor que 6");
                return false;
            }

        }

        public int GetPosicaoX()
        {
            return _PosicaoX;
        }

        public int GetPosicaoY()
        {
            return _PosicaoY;
        }

        public int GetTam()
        {
            return _Tam;
        }
        public int GetEnergia()
        {
            return _Energia;
        }
        public int GetVelocidade()
        {
            return _Velocidade;
        }

    }
}
