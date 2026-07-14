namespace N28_HT1.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsActive { get; set; }

    // Fayl nomlash uchun ishlatiladigan to'liq ism
    public string FullName => $"{FirstName} {LastName}";
}