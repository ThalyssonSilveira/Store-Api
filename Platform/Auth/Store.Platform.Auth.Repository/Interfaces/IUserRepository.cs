using Store.Platform.Auth.Entity.Models;

namespace Store.Platform.Auth.Repository.Interfaces;

public interface IUserRepository
{
    public User GetByLogin(string login);
    public void SaveNewUser(User user);

}