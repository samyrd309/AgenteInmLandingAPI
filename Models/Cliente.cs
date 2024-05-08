using System.ComponentModel.DataAnnotations;

public class Cliente {
    public int Id { get; set; }
    [Required]
    public string? Nombre { get; set; }
    [Required]
    public string? Apellido { get; set; }
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "El número de teléfono ingresado no es válido.")]
    public string? Telefono { get; set; }
    public List<Propiedad> Propiedades { get; set; } = new List<Propiedad>();
    public bool Estado { get; set; } = true;

}