using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaPlaceta_api.Models
{
    public class Pedido_Mesa
    {
        public Pedido_Mesa(string Nombre, int Unidad, float Precio)
        {
            this.Nombre = Nombre;
            this.Unidad = Unidad;
            this.Precio = Precio;
        }

        public string Nombre { get; set; }
        public int Unidad { get; set; }
        public float Precio { get; set; }
    }
}