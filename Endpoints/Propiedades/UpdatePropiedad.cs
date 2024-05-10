using Contracts;
using Entities.Models;
namespace Endpoints.Propiedades;
public class UpdatePropiedad : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("propiedad/update/{id}", (IRepositoryWrapper repositoryWrapper, Propiedad propiedad, int id) =>
        {
            propiedad.Id = id;
            repositoryWrapper.Propiedad.Update(propiedad);
            repositoryWrapper.Save();
            return Results.Ok(propiedad);
        }).WithTags(Tags.Propiedad);

    }
}
