using HMS.DAL.Models;
using System.Linq;

namespace HMS.DAL.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    public UserRepository()
    {
        _context = new AppDbContext();
    }
    public void Add(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public User? Login(string username, string password)
    {
        return _context.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);
    }

    public User? GetByUsername(string username)
    {
        return _context.Users.FirstOrDefault(u => u.Username == username);
    }
}
