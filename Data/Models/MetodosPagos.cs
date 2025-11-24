using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class MetodosPagos
    {
        [Key]
        public int MetodoPagoId { get; set; }
        public string Descripcion { get; set; }
    }

}
