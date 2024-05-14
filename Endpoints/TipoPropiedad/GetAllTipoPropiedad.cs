
using Contracts;

namespace Endpoints.TipoPropiedad;

public class GetAllTipoPropiedad : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("tipopropiedad/", (IRepositoryWrapper repositoryWrapper) => {
            var tipoPropiedad = repositoryWrapper.TipoPropiedad.FindAll();
            return Results.Ok(tipoPropiedad);
        }).WithTags(Tags.TipoPropiedad);
    }
}
