using HMS.DAL.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace HMS.DAL.Models;

public class HousekeepingTask : AuditableEntity
{
    [Key]
    public int TaskID { get; set; }
    public int RoomID { get; set; }
    public Room? Room { get; set; }
    public int EmployeeID { get; set; }
    public Employee? Employee { get; set; }
    public DateTime TaskDate { get; set; }
    public required string Status { get; set; }
}
