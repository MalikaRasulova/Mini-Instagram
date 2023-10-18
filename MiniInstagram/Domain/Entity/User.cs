using System.ComponentModel.DataAnnotations.Schema;

namespace MiniInstagram.Domain.Entity;

[Table("users")]
public class User : AuditableModelBase<long>
{
    [Column("password")] public string Password { get; set; }
    [Column("email")] public string Email { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("surname")] public string Surname { get; set; }
    public List<Photo>? Photos { get; set; }
}