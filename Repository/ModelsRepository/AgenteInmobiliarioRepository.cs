using Contracts.InterfaceRepository;
using Entities;
using Entities.Models;

namespace Repository.ModelsRepository{
    public class AgenteInmobiliarioRepository : RepositoryBase<AgenteInmobiliario>, IAgenteInmobiliarioRepository
    {
        public AgenteInmobiliarioRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}