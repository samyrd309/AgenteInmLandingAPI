
[Table("Clientes")]
public class Cliente {
    [Key]
    [Column("IdCliente")]
    public int Id { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
    public string? Nombre { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
    public string? Apellido { get; set; }
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "El número de teléfono ingresado no es válido.")]
    [DataType(DataType.PhoneNumber)]
    [Display(Name = "Teléfono")]
    public string? Telefono { get; set; }
    [Column("PropiedadesDeInteres")]
    public ICollection<Propiedad> Propiedades { get; set; } 
    public bool Estado { get; set; } 

    public Cliente(){
        Propiedades = new List<Propiedad>();
        Estado = true;
    }

}