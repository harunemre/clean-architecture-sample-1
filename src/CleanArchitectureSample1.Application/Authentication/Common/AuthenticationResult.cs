using CleanArchitectureSample1.Domain.Entities;

namespace CleanArchitectureSample1.Application.Authentication.Common;

public record AuthenticationResult(User User, string Token);