using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Poo
{
    class CasaComercial
    {
        //Campos de la clase casa comercial
        string nombre;
        string email;
        int total;
        List<Vehiculo> vehiculos;

        //Constructor

        public CasaComercial(string nombre, string email, int total, List<Vehiculo> vehiculos)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.Total = total;
            this.Vehiculos = vehiculos;
        }

        //Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public int Total { get => total; set => total = value; }
        internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }

        //Añadimos cada uno de los metodos
        public void AniadirVehiculo(Vehiculo vehiculo)
        {
            try
            {
                //añadimos un nuevo vehiculo a lista vehiculo
                this.vehiculos.Add(vehiculo);
                //Actualizamos el total de vehiculos
                this.total += 1;
                Console.WriteLine("Se ha añadido un nuevo vehiculo\n");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo añadir debido a: {0}", ex.Message);
                Console.ReadLine();
            }
        }
        public void Mostrarvehiculos()
        {
            foreach (var n in this.vehiculos)
            {
                Console.WriteLine("----------");
                n.ToString();
            }
        }
        public void VaciarVehiculo()
        {
            Console.WriteLine("Estas seguro que desea eliminar todos los elementos mostrados en la lista: S/N");
            string resp = Console.ReadLine();
            if (resp == "S" || resp == "s")
            {
                vehiculos = new List<Vehiculo>();
                this.total = 0;
                Console.WriteLine("Se ha eliminado todos los elementos");
            }
            else
            {
                Console.WriteLine("No se elimino, Hay {0} vehiculo registrado", total);
                Console.ReadKey();
            }
        }
        public void EliminarVehiculo(Vehiculo v)
        {
            vehiculos.Remove(v);
            total -= 1;
            Console.WriteLine("Se ha eliminado un registro");
            Console.ReadKey();
        }
    }
}
