using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaPlaceta_api.Models
{
    public class PLATO
    {
        public PLATO(int n_plato, string nombre_plato, decimal precio, int u_restantes)
        {
            NUM_PLATO = n_plato;
            NOMBRE_PLATO = nombre_plato;
            PRECIO = precio;
            UNIDADES_RESTANTES = u_restantes;
        }
        public int NUM_PLATO { get; set; }
        public string NOMBRE_PLATO { get; set; }
        public decimal PRECIO { get; set; }
        public int UNIDADES_RESTANTES { get; set; }
    }
}