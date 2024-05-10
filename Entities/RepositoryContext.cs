using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        public DbSet<Propiedad> Propiedades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<AgenteInmobiliario> AgentesInmobiliarios { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        public DbSet<TipoPropiedad> TiposPropiedades { get; set; }

    }
}