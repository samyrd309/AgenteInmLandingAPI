
using Contracts;

namespace Endpoints.AgenteInmobiliario;

public class DeleteAgenteInmobiliario : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapDelete("/agenteinmobiliario/delete/{id}", (IRepositoryWrapper repositryWrapper, int id) => {
            var agenteInmobiliario = repositryWrapper.AgenteInmobiliario.FindByCondition(a => a.Id == id).FirstOrDefault();
            if (agenteInmobiliario == null) return Results.NotFound();
            repositryWrapper.AgenteInmobiliario.Delete(agenteInmobiliario);
            repositryWrapper.Save();
            return Results.NoContent();
        }).WithTags(Tags.AgenteInmobiliario);
    }
}
