using CleanArchitectureSample1.Application.Common.Interfaces.Authentication;
using CleanArchitectureSample1.Application.Common.Interfaces.Persistence;
using ErrorOr;
using MediatR;
using CleanArchitectureSample1.Domain.Common.Errors;
using CleanArchitectureSample1.Domain.Entities;
using CleanArchitectureSample1.Application.Authentication.Common;

namespace CleanArchitectureSample1.Application.Authentication.Queries.Login;

public class LoginQueryHandler :
    IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtGenerator _jwtGenerator;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(
        IJwtGenerator jwtGenerator,
        IUserRepository userRepository)
    {
        _jwtGenerator = jwtGenerator;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        if (_userRepository.GetUserByEmail(query.Email) is not User user)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        if (user.Password != query.Password)
        {
            return new[] { Errors.Authentication.InvalidCredentials };
        }

        var token = _jwtGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);


    }
}