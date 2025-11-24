using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    
        public class Pagos
        {
            [Key]
            public int PagoId { get; set; }
            public string ClienteId { get; set; }
            public Cliente? Cliente { get; set; }
            public float MontoPagado { get; set; }
            public DateTime FechaPago { get; set; }
            public List<Detalles_Pagos>? DetallesPagos { get; set; } = new();
        }
   }
