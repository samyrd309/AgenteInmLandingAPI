using Contracts;

namespace Endpoints.Cliente
{
    public class DeleteCliente : IEndpoint
    {
        public void MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapDelete("cliente/delete/{id}", (IRepositoryWrapper repositoryWrapper, int id) =>
            {
                var cliente = repositoryWrapper.Cliente.FindByCondition(c => c.Id == id).FirstOrDefault();
                if (cliente == null) return Results.NotFound();
                repositoryWrapper.Cliente.Delete(cliente);
                repositoryWrapper.Save();
                return Results.NoContent();
            }).WithTags(Tags.Cliente);
        }
    }
}