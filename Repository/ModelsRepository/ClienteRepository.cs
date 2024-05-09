using Contracts.InterfaceRepository;
using Entities;
using Entities.Models;

namespace Repository.ModelsRepository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}