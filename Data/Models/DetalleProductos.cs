using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class  DetalleProductos
    {


        [Key]
    public int DetalleId { get; set; }
    public int? ProductoId { get; set; }
    public string? Productos { get; set; }
    public int CarritoId { get; set; }
    public float precio { get; set; }
    public int Cantidad { get; set; }
    public string? Imagen { get; set; }
}
}
