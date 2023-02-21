using CleanArchitectureSample1.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureSample1.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}