using Contracts;

namespace Endpoints.Visita;

public class UpdateVisita : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("visita/update/{id}", (IRepositoryWrapper repositoryWrapper, Entities.Models.Visita visita, int id) =>
        {
            visita.Id = id;
            repositoryWrapper.Visita.Update(visita);
            repositoryWrapper.Save();
            return Results.Ok(visita);
        }).WithTags(Tags.Visita);
    }
}


