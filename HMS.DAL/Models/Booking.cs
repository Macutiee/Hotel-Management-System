using HMS.DAL.Models.Base;

namespace HMS.DAL.Models;

public class Booking : AuditableEntity
{
    public int BookingID { get; set; }
    public int CustomerID { get; set; }
    public Customer? Customer { get; set; }
    public int RoomID { get; set; }
    public Room? Room { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public decimal TotalPrice { get; set; }
    public required string Status { get; set; }
}
