using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persona[] person = new persona[3];

            profesor per1 = new profesor("juan");
            person[0] = per1;

            estudiante per2 = new estudiante("sara");
            person[1] = per2;

            estudiante per3 = new estudiante("carlos");
            person[2] = per3;

            Console.WriteLine("impresion");
            Console.WriteLine(per1.ToString());
            per1.explicar();
            Console.WriteLine(per2.ToString());
            per2.estudiar();
            Console.WriteLine(per3.ToString());
            per3.estudiar();

            Console.ReadKey();
        }
    }
}
