using CleanArchitectureSample1.Domain.Entities;

namespace CleanArchitectureSample1.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token
);