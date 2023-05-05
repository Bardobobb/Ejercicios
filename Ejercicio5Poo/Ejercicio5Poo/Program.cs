using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            album alb = new album(1, "recuerdos", new DateTime(2015, 10, 20), new List<foto>());
            foto f1 = new foto(1, 20, "aqui en miami", new DateTime(2013, 12, 24));
            alb.añadirFoto(f1);
            alb.mostrarFoto();
            alb.tamañoAlbum();
            alb.vaciarAlbum();
            alb.eliminarFoto(f1);
            Console.ReadKey();
        }
    }
}
