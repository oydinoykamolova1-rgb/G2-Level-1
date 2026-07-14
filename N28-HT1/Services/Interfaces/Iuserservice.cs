using N28_HT1.Models;

namespace N28_HT1.Services.Interfaces;

public interface IUserService
{
    List<User> Users { get; }
    User GetById(int id);
}