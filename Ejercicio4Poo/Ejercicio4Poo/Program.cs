using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo(1, "Chevrolet", "Aveo", 5000, 15000, 2017);
            Console.WriteLine(vehiculo.ToString());
            Auto auto = new Auto(1, "Honda", "civic", 20000, 25000, 2019, true);
            auto.Calprecio();
            Console.WriteLine(auto.ToString());
            Moto moto = new Moto(1, "Harley", "Fat boy", 5000, 20000, 2020, true);
            moto.Calprecio();
            Console.WriteLine(moto.ToString());
            Console.ReadKey();
        }
    }
}
