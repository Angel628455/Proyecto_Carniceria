using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string NombreCompleto { get; set; } 

        public string Correo { get; set; } 

        public string Contrasena { get; set; } 

        public string ConfirmacionContrasena { get; set; } 
    }
}
