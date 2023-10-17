using System.ComponentModel.DataAnnotations.Schema;

namespace MiniInstagram.Entity;

[Table("users")]

public class User : AuditableModelBase
{
    [Column("password")]
    public string Password { get; set; }
    [Column("email")]  
    public string Email { get; set; }

}