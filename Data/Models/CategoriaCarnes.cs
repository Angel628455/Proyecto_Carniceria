using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class CategoriaCarnes
    {
        [Key]
        public int CategoriaCarnesId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
