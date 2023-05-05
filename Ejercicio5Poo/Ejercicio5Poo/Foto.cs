using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Poo
{
    internal class foto
    {
        int id;
        int tamanio;
        string comentario;
        DateTime fecha;

        public foto(int id, int tamanio, string comentario, DateTime fecha)
        {
            this.Id = id;
            this.Tamanio = tamanio;
            this.Comentario = comentario;
            this.Fecha = fecha;
        }

        public int Id { get => id; set => id = value; }
        public int Tamanio { get => tamanio; set => tamanio = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public override string ToString()
        {
            return $"id: {Id}\n Tamanio: {Tamanio}\nComentario: {Comentario}nFecha: {Fecha}";
        }
    }
}
