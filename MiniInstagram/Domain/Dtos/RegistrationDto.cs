
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniInstagram.Domain.Dtos;
public class RegistrationDto
{
   [PasswordPropertyText] public string Password { get; set; }
   [EmailAddress] public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}