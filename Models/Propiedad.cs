using System.ComponentModel.DataAnnotations;

public class Propiedad{
    public int Id { get; set; }
    [Required]
    public string Direccion{ get; set; }
    [Required]
    public string ? Ciudad{ get; set; }
    [Required]
    public string ? Provincia{ get; set; }  
    [Required] 
    public string ? Pais{ get; set; }
    [Required]
    public decimal MetrosCuadrados{ get; set; } = 0;
    public decimal Precio{ get; set; } = 0;
    public int NumHabitaciones{ get; set; } = 0;
    public int NumBanos{ get; set; } = 0; 
    public int numParqueaderos{ get; set; } = 0;
    public string? Descripcion{ get; set; }
    public bool Disponible { get; set; } = true;

}
