using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudio estudio = new Estudio("holiwood", "Calle bla", new List<Pelicula>());
            Pelicula pelicula = new Pelicula("La Muerte", 2000, new List<Actor>());
            Actor actor = new Actor("Leonardo", "Di Caprio");
            Console.WriteLine("Nombre del estudio: {0}\nDireccion: {1}\nNombre de la pelicula: {2}\nAño de la pelicula: {3}\nNombre del actor: {4}\nApellido del actor: {5}.", estudio.Nombre, estudio.Direccion, pelicula.Nombre, pelicula.Anio, actor.Nombre, actor.Apellido1);
            Console.ReadKey();
        }
    }
}
