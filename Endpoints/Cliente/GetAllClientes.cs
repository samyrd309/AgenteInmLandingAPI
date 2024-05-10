using Contracts;

namespace Endpoints.Cliente
{
    public class GetAllClientes : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("cliente/", (IRepositoryWrapper repositoryWrapper) =>
            {
                var clientes = repositoryWrapper.Cliente.FindAll();
                return Results.Ok(clientes);
            }).WithTags(Tags.Cliente);
        }
    }
}