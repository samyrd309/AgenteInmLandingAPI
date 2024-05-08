global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;

[Table("Propiedades")]
public class Propiedad{
    [Key]
    [Column("IdPropiedad")]
    public int Id { get; set; }
    [Required]
    public string ? Direccion{ get; set; }
    [Required]
    public string ? Ciudad{ get; set; }
    [Required]
    public string ? Provincia{ get; set; }  
    [Required] 
    public string ? Pais{ get; set; }
    [Required]
    public decimal MetrosCuadrados{ get; set; } 
    public decimal Precio{ get; set; }
    public int NumHabitaciones{ get; set; } 
    public int NumBanos{ get; set; } 
    public int NumParqueaderos{ get; set; } 
    public string? Descripcion{ get; set; }
    [ForeignKey("Cliente")]
    public int IdCliente{ get; set; }
    public Cliente Cliente{ get; set; }
    public bool Disponible { get; set; }

    public Propiedad(){
        MetrosCuadrados = 0;
        Precio = 0;
        NumHabitaciones = 0;
        NumBanos = 0;
        NumParqueaderos = 0;
        Disponible = true;
        Cliente = new Cliente();

    }


}
