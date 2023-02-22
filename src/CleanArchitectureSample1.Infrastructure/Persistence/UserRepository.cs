using CleanArchitectureSample1.Application.Common.Interfaces.Persistence;
using CleanArchitectureSample1.Domain.Entities;

namespace CleanArchitectureSample1.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(u => u.Email == email );
    }
}