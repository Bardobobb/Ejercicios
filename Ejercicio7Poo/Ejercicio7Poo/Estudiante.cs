﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7Poo
{
    class estudiante : persona
    {
        public estudiante(string nombre)
           : base(nombre)
        {

        }
        public void estudiar()
        {
            Console.WriteLine("el estudiante esta estudiando");
        }
    }
}
