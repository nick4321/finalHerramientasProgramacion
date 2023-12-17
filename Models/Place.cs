using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace finalHerramientas.Models
{
    public partial class Place
    {
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public int Dias { get; set; }
        [Required]
        public DateTime FechaIda { get; set; }
        [Required]
        public DateTime FechaRegreso { get; set; }
        [Required]
        public string? Pais { get; set; }
        [Required]
        public string? FotoRuta { get; set; }
    }
}
