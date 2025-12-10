using HMS.DAL.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace HMS.DAL.Models;

public class RevenueReport : AuditableEntity
{
    [Key]
    public int ReportID { get; set; }
    public DateTime Date { get; set; }
    public decimal TotalRevenue { get; set; }
    public int TotalBookings { get; set; }
    public int TotalCustomers { get; set; }
}
