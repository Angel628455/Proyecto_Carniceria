using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public  class Pedidos
    {
        [Key]
        public int PedidoId { get; set; }
        public string? ClienteId { get; set; }
        public List<DetalleProductos> productosOrdenados { get; set; } = new();
        public DateTime Entrega { get; set; }
        public DateTime Recibido { get; set; }
        public float MontoTotal { get; set; }
        public int EstadoId { get; set; }
        public Estados? Estados { get; set; }
    }
}
