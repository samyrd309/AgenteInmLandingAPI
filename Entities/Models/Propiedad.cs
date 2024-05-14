global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities.Models
{
    [Table("Propiedades")]
    public class Propiedad
    {
        [Key]
        [Column("IdPropiedad")]
        public int Id { get; set; }
        [Required]
        public string? Direccion { get; set; }
        /*[Required]
        public string? Ciudad { get; set; }
        */
        [Required]
        public string? Provincia { get; set; }
        [Required]
        public string? Pais { get; set; }
        [Required]
        public decimal MetrosCuadrados { get; set; }
        public decimal Precio { get; set; }
        public int NumHabitaciones { get; set; }
        public int NumBanos { get; set; }
        public int NumParqueaderos { get; set; }
        public string? Descripcion { get; set; }
        public bool Disponible { get; set; }
        /*
        // Claves foraneas Clientes
        [ForeignKey("Cliente")]
        [JsonIgnore]
        public int IdCliente { get; set; }
        [JsonIgnore]
        public Cliente ? Cliente { get; set; }
        // Claes foraneas AgenteInmobiliario
        [ForeignKey("AgenteInmobiliario")]
        [JsonIgnore]
        public int IdAgenteInmobiliario { get; set; }
        [JsonIgnore]
        public AgenteInmobiliario ? AgenteInmobiliario { get; set; }
        // Claves foraneas TipoPropiedad
        [ForeignKey(nameof(TipoPropiedad))]
        [JsonIgnore]
        public int IdTipoPropiedad { get; set; }
        [JsonIgnore]
        public TipoPropiedad ? TipoPropiedad { get; set; }
        
        public ICollection<Visita> Visitas { get; set; }
        */
        public Propiedad()
        {
            MetrosCuadrados = 0;
            Precio = 0;
            NumHabitaciones = 0;
            NumBanos = 0;
            NumParqueaderos = 0;
            Disponible = true;
            /*
            Cliente = new Cliente();
            AgenteInmobiliario = new AgenteInmobiliario();
            TipoPropiedad = new TipoPropiedad();
            Visitas = new List<Visita>();
            */

        }


    }

}