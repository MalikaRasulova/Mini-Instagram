using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace MiniInstagram.Domain.Entity;

[Table("photos")]
public class Photo : AuditableModelBase<Guid>
{
    [Column("name")] public string Name { get; set; }

    [Column("user_id"), ForeignKey(nameof(User))]
    public long UserId { get; set; }

    [JsonIgnore] public User User { get; set; }
}