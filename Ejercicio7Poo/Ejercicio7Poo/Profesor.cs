﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7Poo
{
    class profesor : persona
    {
        public profesor(string nombre)
            : base(nombre)
        {

        }
        public void explicar()
        {
            Console.WriteLine("el profesor esta explicando");
        }
    }
}
