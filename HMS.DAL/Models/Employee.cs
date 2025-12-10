using HMS.DAL.Models.Base;

namespace HMS.DAL.Models;

public class Employee : AuditableEntity
{
    public int EmployeeID { get; set; }
    public required string FullName { get; set; }
    public required string Phone { get; set; }
    public string Email { get; set; } = string.Empty;
    public int RoleID { get; set; } 
    public Role? Role { get; set; }
}
