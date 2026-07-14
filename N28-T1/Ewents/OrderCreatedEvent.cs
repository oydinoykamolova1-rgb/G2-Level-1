namespace N28_T1.Ewents;

public class OrderCreatedEvent
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public decimal Amount { get; set; }

    public DateTime OccuredAt { get; set; } = DateTime.UtcNow;
}
