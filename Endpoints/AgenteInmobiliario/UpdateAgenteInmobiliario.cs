
using Contracts;

namespace Endpoints.AgenteInmobiliario;

public class UpdateAgenteInmobiliario : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("/agenteinmobiliario/update/{id}", (IRepositoryWrapper repositryWrapper, Entities.Models.AgenteInmobiliario agenteInmobiliario, int id) => {
            
            agenteInmobiliario.Id = id;
            repositryWrapper.AgenteInmobiliario.Update(agenteInmobiliario);
            repositryWrapper.Save();
            return Results.Ok(agenteInmobiliario);
        }).WithTags(Tags.AgenteInmobiliario);
    }
}
