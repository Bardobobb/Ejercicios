using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10Poo
{
    public class Empleado : Persona
    {
        public Empleado(string nombre, int edad, decimal sueldoBruto) : base(nombre, edad)
        {
            SueldoBruto = sueldoBruto;
        }

        public decimal SueldoBruto { get; set; }

        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Sueldo Bruto: {SueldoBruto}");
        }

        public decimal CalcularSalarioNeto()
        {

            decimal seguro = SueldoBruto * 0.12m;
            decimal salarioneto = SueldoBruto - seguro;
            return salarioneto;
        }
    }
}
