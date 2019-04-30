using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Entities
{
    public class CarritoEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CasaProductora { get; set; }
        public double Precio { get; set; }
        public int cantidad { get; set; }
        public double total { get; set; }
    }
}
