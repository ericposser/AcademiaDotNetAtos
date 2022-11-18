using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO
{
    class PlayStation : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("estou ligando o play");
            //ligado = true;
            this.Ligado = true;
        }

    }
}
