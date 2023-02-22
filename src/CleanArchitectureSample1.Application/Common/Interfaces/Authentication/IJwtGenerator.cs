using CleanArchitectureSample1.Domain.Entities;

namespace CleanArchitectureSample1.Application.Common.Interfaces.Authentication;

public interface IJwtGenerator
{
    public string GenerateToken(User user);
}