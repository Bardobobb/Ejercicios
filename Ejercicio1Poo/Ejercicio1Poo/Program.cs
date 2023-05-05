using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando un nuevo objeto de la calse vehiculo
            Vehiculo vehiculo = new Vehiculo(1, "Chevrolet", "Aveo", 5000, 15000, 2017);
            Console.WriteLine(vehiculo.ToString());
            Console.ReadKey();
        }
    }
}
