
using Contracts;

namespace Endpoints.AgenteInmobiliario;

public class CreateAgenteInmobiliario : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("/agenteinmobiliario/create", (IRepositoryWrapper repositryWrapper, Entities.Models.AgenteInmobiliario agenteInmobiliario) => {
            repositryWrapper.AgenteInmobiliario.Create(agenteInmobiliario);
            repositryWrapper.Save();
            return Results.Created($"/agenteinmobiliario/{agenteInmobiliario.Id}", agenteInmobiliario);
        }).WithTags(Tags.AgenteInmobiliario);
    }
}