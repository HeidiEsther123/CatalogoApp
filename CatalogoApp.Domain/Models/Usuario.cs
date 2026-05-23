using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoApp.Domain.Models
{
     public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }
}
