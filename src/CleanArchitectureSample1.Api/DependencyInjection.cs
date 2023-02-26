using CleanArchitectureSample1.Api.Mapping;

namespace CleanArchitectureSample1.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddMappings();

        return services;
    }
}