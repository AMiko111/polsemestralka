using UTB.Minute.Db.Enums;

namespace UTB.Minute.Db.Entities;

public class Order
{
    public int Id { get; set; }
    public int MenuItemId { get; set; }
    public MenuItem MenuItem { get; set; } = null!;
    public string StudentId { get; set; } = string.Empty;
    public OrderStatus Status { get; set; } = OrderStatus.Preparing;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
