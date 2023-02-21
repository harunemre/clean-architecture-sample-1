namespace CleanArchitectureSample1.Application.Common.Interfaces.Authentication;

public interface IJwtGenerator
{
    public string GenerateToken(Guid userId, string firstName, string lastName);
}