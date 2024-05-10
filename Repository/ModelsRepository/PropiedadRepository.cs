using Contracts.InterfaceRepository;
using Entities;
using Entities.Models;

namespace Repository.ModelsRepository
{
    public class PropiedadRepository : RepositoryBase<Propiedad>, IPropiedadRepository
    {
        public PropiedadRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}