using Contracts.InterfaceRepository;
using Entities;
using Entities.Models;

namespace Repository.ModelsRepository
{
    public class TipoPropiedadRepository : RepositoryBase<TipoPropiedad>, ITipoPropiedadRepository
    {
        public TipoPropiedadRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}