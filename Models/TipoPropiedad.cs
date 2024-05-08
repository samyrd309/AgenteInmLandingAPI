public class TipoPropiedad {
    public int Id { get; set; }
    [Required]
    public string? Nombre { get; set; }
    public ICollection<Propiedad> Propiedades { get; set; }

    public TipoPropiedad(){
        Propiedades = new List<Propiedad>();
    }
}