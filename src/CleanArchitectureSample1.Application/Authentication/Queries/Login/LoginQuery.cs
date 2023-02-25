using CleanArchitectureSample1.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace CleanArchitectureSample1.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password
) : IRequest<ErrorOr<AuthenticationResult>>;