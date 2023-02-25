using CleanArchitectureSample1.Application.Common.Interfaces.Authentication;
using CleanArchitectureSample1.Application.Common.Interfaces.Persistence;
using ErrorOr;
using MediatR;
using CleanArchitectureSample1.Domain.Common.Errors;
using CleanArchitectureSample1.Domain.Entities;
using CleanArchitectureSample1.Application.Authentication.Common;

namespace CleanArchitectureSample1.Application.Authentication.Commands.Register;

public class RegisterCommandHandler :
    IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtGenerator _jwtGenerator;
    private readonly IUserRepository _userRepository;

    public RegisterCommandHandler(
        IJwtGenerator jwtGenerator,
        IUserRepository userRepository)
    {
        _jwtGenerator = jwtGenerator;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        if (_userRepository.GetUserByEmail(command.Email) is not null)
        {
            return Errors.User.DuplicateEmail;
        }

        var user = new User
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            Password = command.Password
        };

        _userRepository.Add(user);

        var token = _jwtGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token
        );

    }
}