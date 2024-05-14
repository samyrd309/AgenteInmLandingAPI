using Contracts;

namespace Endpoints.Ciudad;

public class CreateCiudad : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("ciudad/create", (IRepositoryWrapper repositoryWrapper, Entities.Models.Ciudad ciudad)=> {
            repositoryWrapper.Ciudad.Create(ciudad);
            repositoryWrapper.Save();
            return Results.Ok(ciudad);
        }).WithTags(Tags.Ciudad);
    }
}
