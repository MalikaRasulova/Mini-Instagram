using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MiniInstagram.Domain.Enum;



namespace MiniInstagram.Domain.Entity;

[Table("friends")]
public class Friend : AuditableModelBase<long>
{
    [Column("user_id"), ForeignKey(nameof(Owner))]
    public long UserId { get; set; }

    [JsonIgnore] public User Owner { get; set; }

    [Column("friend_id"), ForeignKey(nameof(Friends))]
    public long FriendId { get; set; }

    [JsonIgnore] public User Friends { get; set; }

    [Column("status")] public FriendsStatus Status { get; set; }

}