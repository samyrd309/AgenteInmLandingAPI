
using Contracts;

namespace Endpoints.AgenteInmobiliario;

public class GetAllAgenteInmobiliarios : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/agenteinmobiliario/", (IRepositoryWrapper repositryWrapper) => {
            var agenteInmobiliarios = repositryWrapper.AgenteInmobiliario.FindAll();
            return Results.Ok(agenteInmobiliarios);
        }).WithTags(Tags.AgenteInmobiliario);
    }
}