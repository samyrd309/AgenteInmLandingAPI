using Entities.Models;
using Microsoft.EntityFrameworkCore;
namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }
        public DbSet<TipoPropiedad> TipoPropiedades { get; set; }
        public DbSet<Propiedad> Propiedades { get; set; }
        
        public DbSet<AgenteInmobiliario> AgentesInmobiliarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Visita> Visitas { get; set; }

    }
}