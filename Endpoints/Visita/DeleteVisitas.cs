using Contracts;

namespace Endpoints.Visita;

public class DeleteVisitas : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapDelete("visita/delete/{id}", (IRepositoryWrapper repositoryWrapper, int id) =>
        {
            var visita = repositoryWrapper.Visita.FindByCondition(x => x.Id == id).FirstOrDefault();
            if (visita == null) return Results.NotFound();
            repositoryWrapper.Visita.Delete(visita);
            repositoryWrapper.Save();
            return Results.Ok(visita);
        }).WithTags(Tags.Visita);
    }
    
}


