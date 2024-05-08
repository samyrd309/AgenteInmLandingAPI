using Entities.Models;
namespace Entities.Models
{
    [Table("TipoPropiedades")]
    public class TipoPropiedad
    {
        [Key]
        [Column("IdTipoPropiedad")]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        public ICollection<Propiedad> Propiedades { get; set; }

        public TipoPropiedad()
        {
            Propiedades = new List<Propiedad>();
        }
    }
}