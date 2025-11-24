using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Detalles_Pagos
    {
        [Key]
        public int DetallePagoId { get; set; }
        public int PedidoId { get; set; }
        public Pedidos? Pedidos { get; set; }
        public int PagoId { get; set; }
        public Pagos? Pagos { get; set; }
        public int MetodoPagoId { get; set; }
        public MetodosPagos? MetodosPagos { get; set; }
        public float MontoPagado { get; set; }
    }
}
