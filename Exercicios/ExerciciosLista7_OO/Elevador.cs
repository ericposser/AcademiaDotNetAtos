using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista7
{
    internal class Elevador
    {
        private int andar = 0;
        private int total_andares;
        private int capacidade;
        private int qtdPessoas = 0;

        public Elevador(int total_andares, int capacidade)
        {
            this.total_andares = total_andares;
            this.capacidade = capacidade;
        }

        public void entra()
        {
            if (qtdPessoas == capacidade)
            {
                Console.WriteLine("Nao ha mais espaço no elevador");
            }
            else
            {
                qtdPessoas++;
            }
        }

        public void sai()
        {
            if (qtdPessoas == 0)
            {
                Console.WriteLine("Não ha ninguem no elevador");
            }
            else
            {
                qtdPessoas--;
            }
        }

        public void sobe()
        {
            if (andar == total_andares)
            {
                Console.WriteLine("Ja estamos no ultimo andar");
            }
            else
            {
                andar++;
                Console.WriteLine("Subindo");
            }
        }

        public void desce()
        {
            if (andar == 0)
            {
                Console.WriteLine("Não há como descer mais");
            }
            else
            {
                andar--;
                Console.WriteLine("Descendo");
            }
        }

        public void setAndar(int andar)
        {
            this.andar = andar;
        }
        public int getAndar()
        {
            return andar;
        }

        public void setTotalAndares(int andares)
        {
            total_andares = andares;
        }

        public int getTotalAndares()
        {
            return total_andares;
        }

        public void setCapacidade(int capacidade)
        {
            this.capacidade = capacidade;
        }

        public int getCapacidade()
        {
            return capacidade;
        }

        public void setQtdPessoas(int qtdPessoas)
        {
            this.qtdPessoas = qtdPessoas;
        }

        public int getQtdPessoas()
        {
            return qtdPessoas;
        }

    }
}
