using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De el nombre de la casa comercial: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingresa el email: ");
            string email = Console.ReadLine();

            CasaComercial cc = new CasaComercial(nombre, email, 0, new List<Vehiculo>());
            Console.WriteLine("Informacion del vehiculo a añadir");
            Console.WriteLine("Modelo: ");
            string model = Console.ReadLine();
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine("kilometraje: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Año: ");
            int annio = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            //info del nuevo vehiculo usando añadir vehiculo
            cc.AniadirVehiculo(new Vehiculo(1, marca, model, km, precio, annio));
            Console.WriteLine("\nAcontinuacion mostrara todos los vehiculos de la lista: ");
            cc.Mostrarvehiculos();
            Console.WriteLine("Desea vaciar la lista: S/N");
            string rep = Console.ReadLine();
            if (rep == "s" || rep == "S")
            {
                cc.VaciarVehiculo();
            }
            Console.ReadKey();
        }
    }
}
