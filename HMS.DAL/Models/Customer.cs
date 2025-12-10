using HMS.DAL.Models.Base;

namespace HMS.DAL.Models;

public class Customer : AuditableEntity
{
    public int CustomerID { get; set; }
    public required string FullName { get; set; }
    public required string Phone { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public required string IDCard { get; set; } 
}
