using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista7
{
    internal class ControleRemoto
    {
        public int abaixar_volume(int volume)
        {
            if (volume <= 0)
            {
                Console.WriteLine("Não ha como abaixar mais o volume");
            }
            else
            {
                volume--;
            }
            return volume;
        }
        public int aumentar_volume(int volume)
        {

            volume++;

            return volume;
        }

        public int trocar_canal()
        {
            int canal;
            Console.WriteLine("Para qual canal deseja trocar?");
            canal = int.Parse(Console.ReadLine());



            return canal;
        }

        public void consultarCanalEVolume(int canal, int volume)
        {
            Console.WriteLine("volume: " + volume + "\n Canal: " + canal);
        }
    }
}
