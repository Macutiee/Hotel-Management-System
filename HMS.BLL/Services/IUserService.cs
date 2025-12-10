using HMS.DAL.Models;

namespace HMS.BLL.Services;

public interface IUserService
{
    bool Login(string username, string password);
    User? Authenticate(string username, string password);
    void Register(string username, string password, string fullName);
}
