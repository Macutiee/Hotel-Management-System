using HMS.DAL.Models;

namespace HMS.DAL.Repositories;

public interface IUserRepository
{
    User? GetByUsername(string username);
    User? Login(string username, string password);
    void Add(User user);
}
