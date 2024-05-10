using Contracts;

namespace Endpoints.Cliente
{
    public class UpdateCliente : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPut("cliente/update/{id}", (IRepositoryWrapper repositoryWrapper, Entities.Models.Cliente cliente, int id) =>
            {
                cliente.Id = id;
                repositoryWrapper.Cliente.Update(cliente);
                repositoryWrapper.Save();
                return Results.Ok(cliente);
            }).WithTags(Tags.Cliente);
        }
    }
}