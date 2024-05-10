using Contracts;
using Entities.Models;
namespace Endpoints.Propiedades;
public class CreatePropiedad : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("propiedad/create",  (IRepositoryWrapper repositoryWrapper, Propiedad propiedad) => {
            repositoryWrapper.Propiedad.Create(propiedad);
            repositoryWrapper.Save();
            return Results.Created($"/{propiedad.Id}", propiedad);
        })
        .WithTags(Tags.Propiedad);
    }
}
