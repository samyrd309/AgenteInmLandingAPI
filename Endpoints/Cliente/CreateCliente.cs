using Contracts;

namespace Endpoints.Cliente
{
    public class CreateCliente : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapPost("cliente/create", (IRepositoryWrapper repositoryWrapper, Entities.Models.Cliente cliente) =>
            {
                repositoryWrapper.Cliente.Create(cliente);
                repositoryWrapper.Save();
                return Results.Created($"/{cliente.Id}", cliente);
            })
            .WithTags(Tags.Cliente);
        }
    }
}