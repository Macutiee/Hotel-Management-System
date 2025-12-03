namespace HMS.DAL.Models;

public class User
{
    public int UserID { get; set; }
    public required string Username { get; set; }
    public string PasswordHash { get; set; } = string.Empty;
    public required string FullName { get; set; }
    public int RoleID { get; set; }
    public Role? Role { get; set; }
}
