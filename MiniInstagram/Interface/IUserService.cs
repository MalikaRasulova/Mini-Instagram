
using MiniInstagram.Domain.Dtos;
using MiniInstagram.Domain.Entity;
namespace MiniInstagram.Interface;
public interface IUserService
{
    public ValueTask<User> CreateAsync(RegistrationDto dto);
    public ValueTask<User> GetUserByEmailAndPasswordAsync(string password,string email);
}