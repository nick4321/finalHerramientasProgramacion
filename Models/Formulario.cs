namespace finalHerramientas.Models
{
    public partial class Formulario

    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public required Lugar SitioReservado { get; set; }
    }
}
