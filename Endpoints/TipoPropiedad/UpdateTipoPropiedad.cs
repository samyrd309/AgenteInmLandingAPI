
using Contracts;

namespace Endpoints.TipoPropiedad;

public class UpdateTipoPropiedad : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("tipopropiedad/update/{id}", (IRepositoryWrapper repositoryWrapper, Entities.Models.TipoPropiedad tipoPropiedad, int id)=>{
            tipoPropiedad.Id = id; 
            repositoryWrapper.TipoPropiedad.Update(tipoPropiedad);
            repositoryWrapper.Save();
            return Results.Ok(tipoPropiedad);
        }).WithTags(Tags.TipoPropiedad);
    }

}
