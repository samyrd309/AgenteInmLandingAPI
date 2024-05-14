using Contracts;

namespace Endpoints.Visita;

public class GetAllVisitas : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("visita/getall", (IRepositoryWrapper repositoryWrapper) =>
        {
            var visitas = repositoryWrapper.Visita.FindAll();
            return Results.Ok(visitas);
        }).WithTags(Tags.Visita);
    }
}


