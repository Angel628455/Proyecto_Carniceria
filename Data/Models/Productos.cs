using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string? Nombre { get; set; }
        public string? ImagenProducto { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public float PrecioLibra { get; set; }
        public float CostoLibra { get; set; }
        public int Stock { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int CategoriaCarneId { get; set; }
        public CategoriaCarnes? CategoriaCarnes { get; set; }
    }
}
