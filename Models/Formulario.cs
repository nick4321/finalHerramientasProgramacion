using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace finalHerramientas.Models
{
    public partial class Formulario

    {
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido { get; set; }
        [Required]
        public string? Correo { get; set; }
        [Required]
        public required Place SitioReservado { get; set; }
    }
}
