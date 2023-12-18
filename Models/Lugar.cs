using finalHerramientas.Utils;

namespace finalHerramientas.Models
{
    public partial class Lugar
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Dias { get; set; }
        public DateTime FechaIda { get; set; }
        public DateTime FechaRegreso { get; set; }
        public Paises Pais { get; set; }
        public string? FotoRuta { get; set; }
    }
}
