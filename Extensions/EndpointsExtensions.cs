using System.Reflection;

using Endpoints;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Extensions;

public static class EndPointsExtensions{
    public static IServiceCollection AddEndpoints(this IServiceCollection services, Assembly assembly){
        ServiceDescriptor[] endpointsServiceDecriptors = assembly
            .DefinedTypes
            .Where(type => type is {IsAbstract: false, IsInterface: false} &&
                           type.IsAssignableTo(typeof(IEndpoint)))
            .Select(type=> ServiceDescriptor.Transient(typeof(IEndpoint), type))
            .ToArray();
        services.TryAddEnumerable(endpointsServiceDecriptors);

        return services;
    }

    public static IApplicationBuilder MapEndpoints(this WebApplication app){
        app.Services.GetRequiredService<IEnumerable<IEndpoint>>()
            .ToList()
            .ForEach(endpoint => endpoint.MapEndpoint(app));

        return app;
    }
}