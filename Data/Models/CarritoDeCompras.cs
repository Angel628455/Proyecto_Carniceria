using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class CarritoDeCompras
    {
        [Key]
        public int CarritoId { get; set; }
        public string ClienteId { get; set; }
        public List<DetalleProductos> Productos { get; set; } = new();
        public float MontoTotal { get; set; }
        public bool Compra { get; set; }
    }
}
