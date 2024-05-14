using Entities;
using Entities.Models;
using Repository;

namespace Contracts.InterfaceRepository
{
    public class CiudadRepository : RepositoryBase<Ciudad>, ICiudadRepository
    {
        public CiudadRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}