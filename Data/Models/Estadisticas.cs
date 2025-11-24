using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Estadisticas
    {
        [Key]
        public int EstadisticaId { get; set; }

        // Cantidad total de pedidos registrados en el sistema
        public int TotalPedidos { get; set; }

        // Cantidad total de pagos realizados
        public int TotalPagos { get; set; }

        // Ingresos generados (suma de pagos)
        public float IngresosTotales { get; set; }

        // Cantidad de clientes registrados
        public int TotalClientes { get; set; }

        // Cantidad de productos registrados
        public int TotalProductos { get; set; }

        // Ventas del día
        public float VentasHoy { get; set; }

        // Pedidos del día
        public int PedidosHoy { get; set; }

        // Fecha del reporte
        public DateTime FechaActualizacion { get; set; } = DateTime.Now;
    }
}
