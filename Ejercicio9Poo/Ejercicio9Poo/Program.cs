using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camionero cami = new Camionero(1, 1200, "calle....", 234566, "Eze", "matel", new Camion(1200, "12234", "rayo", "viper"), new List<Paquete>());
            Paquete pack = new Paquete(123, "paquete", "casa 123", "Managua", new Ciudad(29292, "Managua"));
            Console.WriteLine(cami.ToString());
            cami.ToString();
            cami.AgregarPack(pack);
            Console.ReadKey();
        }
    }
}
