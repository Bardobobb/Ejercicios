using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona per = new Persona("Maria", 29);
            per.Mostrar();

            Cliente cli = new Cliente("MArlon", 35, "1234556");
            cli.Mostrar();

            Empleado emp = new Empleado("Marez", 26, 80000);
            emp.Mostrar();

            decimal salan = emp.CalcularSalarioNeto();
            Console.WriteLine("Salario neto: {0}", salan);

            Empresa empresa = new Empresa("El Verdugo");

            Directivo direc = new Directivo("Robert", 49, "Gerente");
            direc.Mostrar();

            Console.ReadKey();
        }
    }
}
