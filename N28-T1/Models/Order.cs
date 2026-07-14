namespace N28_T1.Models;

public class Order
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public User? User { get; set; }

    public decimal Amount { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
