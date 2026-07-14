using N28_HT1.Models;
using N28_HT1.Services.Interfaces;

namespace N28_HT1.Services;

public class UserService : IUserService
{
    public List<User> Users { get; } = new List<User>
    {
        new User { Id = 1, FirstName = "Ali", LastName = "Valiyev", IsActive = true },
        new User { Id = 2, FirstName = "Vali", LastName = "Aliyev", IsActive = true },
        new User { Id = 3, FirstName = "Sardor", LastName = "Karimov", IsActive = false }
    };

    public User GetById(int id)
    {
        var user = Users.FirstOrDefault(u => u.Id == id);
        if (user == null)
            throw new KeyNotFoundException($"Id={id} bo'yicha user topilmadi");

        return user;
    }
}
