using Contracts;

namespace Endpoints.Ciudad;

public class UpdateCiudad : IEndpoint{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("ciudad/update", (IRepositoryWrapper repositoryWrapper, Entities.Models.Ciudad ciudad)=> {
            repositoryWrapper.Ciudad.Update(ciudad);
            repositoryWrapper.Save();
            return Results.Ok(ciudad);
        }).WithTags(Tags.Ciudad);
    }
}