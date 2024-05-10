using Contracts;
namespace Endpoints.Propiedades;
public class GetAllPropiedades : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("propiedad/", (IRepositoryWrapper repositoryWrapper) =>
        {
            var propiedades = repositoryWrapper.Propiedad.FindAll();
            return Results.Ok(propiedades);
        }).WithTags(Tags.Propiedad);
    }
}
