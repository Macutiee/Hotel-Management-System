using HMS.DAL.Models.Base;

namespace HMS.DAL.Models;

public class Room : AuditableEntity
{
    public int RoomID { get; set; }
    public required string RoomNumber { get; set; }
    public required string RoomType { get; set; }
    public decimal PricePerNight { get; set; }
    public bool IsAvailable { get; set; }
}
