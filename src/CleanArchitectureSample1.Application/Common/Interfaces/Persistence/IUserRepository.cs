using CleanArchitectureSample1.Domain.Entities;

namespace CleanArchitectureSample1.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}