namespace N28_T1.Models;

public class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string TelegramUsername { get; set; } = string.Empty;

    public List<Order> orders { get; set; } = new List<Order>();

    public Bonus? Bonus { get; set; }   
}
