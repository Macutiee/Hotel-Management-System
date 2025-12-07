using HMS.DAL.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace HMS.DAL.Models;

public class Role : AuditableEntity
{
    [Key]
    public int RoleID { get; set; }
    public required string RoleName { get; set; }
}
