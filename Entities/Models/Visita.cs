namespace Entities.Models
{
    [Table("Visitas")]
    public class Visita
    {
        [Key]
        [Column("IdVisita")]
        public int Id { get; set; }
        [Required]
        public DateTime FechaHora { get; set; }
        /*
        [Required]
        // Clave foránea para AgenteInmobiliario
        [ForeignKey(nameof(AgenteInmobiliario))]
        public int AgenteInmobiliarioId { get; set; }
        [Required]
        // Propiedad de navegación para AgenteInmobiliario
        public AgenteInmobiliario AgenteInmobiliario { get; set; }
        [Required]
        // Clave foránea para Cliente
        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }
        [Required]
        public Cliente Cliente { get; set; }

        // Clave foránea para Propiedad
        [ForeignKey(nameof(Propiedad))]
        public int PropiedadId { get; set; }

        // Propiedad de navegación para Propiedad
        public Propiedad Propiedad { get; set; }
        */

        public Visita()
        {
            FechaHora = DateTime.Now;
            /*
            AgenteInmobiliario = new AgenteInmobiliario();
            Cliente = new Cliente();
            Propiedad = new Propiedad();
            */
        }
    }
}