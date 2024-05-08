using Entities.Models;
namespace Entities.Models
{
    [Table("AgentesInmobiliarios")]
    public class AgenteInmobiliario
    {
        [Key]
        [Column("IdAgenteInmobiliario")]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string? Nombre { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
        public string? Apellido { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "El número de teléfono ingresado no es válido.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono")]
        public string? Telefono { get; set; }

        public ICollection<Propiedad> Propiedades { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Visita> Visitas { get; set; }
        public DateTime FechaContratacion { get; set; }

        public AgenteInmobiliario()
        {
            Propiedades = new List<Propiedad>();
            Clientes = new List<Cliente>();
            Visitas = new List<Visita>();
            FechaContratacion = DateTime.Now;
        }

    }
}