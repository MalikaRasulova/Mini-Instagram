
using MiniInstagram.Domain.Entity;
using MiniInstagram.Domain.Dtos;
namespace MiniInstagram.Interface;
public interface IAuthService
{
    public ValueTask<string> LoginAsync(LoginDto dto);
    public ValueTask<User> RegistrationAsync(RegistrationDto dto);
}