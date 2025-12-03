using BCrypt.Net;
using HMS.DAL.Models;
using HMS.DAL.Repositories;

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

    public User? LoginCheat(string userName, string password)
    {
        return _userRepository.Login(userName, password);
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
