public class Visita
{
    public int Id { get; set; }
    public DateTime FechaHora { get; set; }

    // Clave foránea para AgenteInmobiliario
    [ForeignKey("AgenteInmobiliario")]
    public int AgenteInmobiliarioId { get; set; }

    // Propiedad de navegación para AgenteInmobiliario
    public AgenteInmobiliario AgenteInmobiliario { get; set; }

    // Clave foránea para Cliente
    [ForeignKey("Cliente")]
    public int ClienteId { get; set; }

    // Propiedad de navegación para Cliente
    public Cliente Cliente { get; set; }

    // Clave foránea para Propiedad
    [ForeignKey("Propiedad")]
    public int PropiedadId { get; set; }

    // Propiedad de navegación para Propiedad
    public Propiedad Propiedad { get; set; }
}