
using Contracts;

namespace Endpoints.TipoPropiedad;

public class CreateTipoPropiedad : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("tipopropiedad/create", (IRepositoryWrapper repositoryWrapper, Entities.Models.TipoPropiedad tipoPropiedad)=> {
            repositoryWrapper.TipoPropiedad.Create(tipoPropiedad);
            repositoryWrapper.Save();
            return Results.Ok(tipoPropiedad);
        }).WithTags(Tags.TipoPropiedad);
    }
}

public class DeleteTipoPropiedad : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapDelete("tipopropiedad/delete/{id}", (IRepositoryWrapper repositoryWrapper, int id)=> {
            var tipoPropiedad = repositoryWrapper.TipoPropiedad.FindByCondition(tp => tp.Id == id).FirstOrDefault();
            if (tipoPropiedad == null) return Results.NotFound();
            repositoryWrapper.TipoPropiedad.Delete(tipoPropiedad);
            repositoryWrapper.Save();
            return Results.NoContent();
        }).WithTags(Tags.TipoPropiedad);
    }
}