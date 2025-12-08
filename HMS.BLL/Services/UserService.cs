using BCrypt.Net;
using HMS.DAL.Models;
using HMS.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HMS.BLL.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public bool Login(string username, string password)
    {
        var user = _userRepository.GetByUsername(username);
        if (user == null) return false;

        return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
    }

    public User? Authenticate(string username, string password)
    {
        var user = _userRepository.GetByUsername(username);
        if (user == null)
            return null;

        bool match = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
        return match ? user : null;
    }

    public void Register(string username, string password, string fullname)
    {
        var hashed = BCrypt.Net.BCrypt.HashPassword(password);

        var user = new User
        {
            Username = username,
            PasswordHash = hashed,
            FullName = fullname,
            RoleID = 1
        };

        _userRepository.Add(user);
    }
}
