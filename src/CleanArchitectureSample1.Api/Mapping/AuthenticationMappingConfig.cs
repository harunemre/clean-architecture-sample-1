using CleanArchitectureSample1.Application.Authentication.Commands.Register;
using CleanArchitectureSample1.Application.Authentication.Common;
using CleanArchitectureSample1.Application.Authentication.Queries.Login;
using CleanArchitectureSample1.Contracts.Authentication;
using Mapster;

namespace CleanArchitectureSample1.Api.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();
        config.NewConfig<LoginRequest, LoginQuery>();
        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}