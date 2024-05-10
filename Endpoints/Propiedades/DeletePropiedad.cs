using Contracts;
namespace Endpoints.Propiedades;
public class DeletePropiedad : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapDelete("propiedad/delete/{id}",  (IRepositoryWrapper repositoryWrapper, int id) => {
            var propiedad = repositoryWrapper.Propiedad.FindByCondition(p => p.Id == id).FirstOrDefault();
            if (propiedad == null) return Results.NotFound();
            repositoryWrapper.Propiedad.Delete(propiedad);
            repositoryWrapper.Save();
            return Results.NoContent();
        }).WithTags(Tags.Propiedad);
    }
}
