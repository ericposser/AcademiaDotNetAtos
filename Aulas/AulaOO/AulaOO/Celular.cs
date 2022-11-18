using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO
{
    class Celular : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("android iniciando");
            //ligado = true;
            this.Ligado = true;
        }

    }
}
