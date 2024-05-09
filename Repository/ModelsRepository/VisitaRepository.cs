using Entities.Models;
using Contracts.InterfaceRepository;
using Entities;

namespace Repository.ModelsRepository{
    public class VisitaRepository : RepositoryBase<Visita>, IVistasRepository
    {
        public VisitaRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}