
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniInstagram.Domain.Dtos;
public class LoginDto
{
    [EmailAddress]
    public string Email { get; set; }
    [PasswordPropertyText]
    public string Password { get; set; }
}