﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO
{
    class Televisao : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("WebOS ligando");
            //ligado = true;
            this.Ligado = true;
        }
    }
}
