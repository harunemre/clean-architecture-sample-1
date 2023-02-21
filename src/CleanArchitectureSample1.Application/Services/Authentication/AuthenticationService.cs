using CleanArchitectureSample1.Application.Common.Interfaces.Authentication;

namespace CleanArchitectureSample1.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtGenerator _jwtGenerator;

    public AuthenticationService(IJwtGenerator jwtGenerator)
    {
        _jwtGenerator = jwtGenerator;
    }

    public AuthenticationResult Login(string email, string password)
    {

        return new AuthenticationResult(
            Guid.NewGuid(),
             "firstName",
             "lastName",
             email,
             "token"
             );
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {

        var userId = Guid.NewGuid();
        var token = _jwtGenerator.GenerateToken(userId, firstName, lastName);

        return new AuthenticationResult(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            token
        );
    }
}