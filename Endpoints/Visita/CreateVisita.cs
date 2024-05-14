using Contracts;

namespace Endpoints.Visita;

public class CreateVisita : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("visita/create", (IRepositoryWrapper repositoryWrapper, Entities.Models.Visita visita) =>
        {
            repositoryWrapper.Visita.Create(visita);
            repositoryWrapper.Save();
            return Results.Ok(visita);
        }).WithTags(Tags.Visita);
    }
}