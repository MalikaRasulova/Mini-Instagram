using System.ComponentModel.DataAnnotations.Schema;
using PictureSharing.Entity;

namespace MiniInstagram.Entity;
[Table("friends")]
public class Friends : BaseModel
{
    [Column("from_id"),ForeignKey(nameof(Client))]
    public long FromId { get; set; }
    [Column("to_id"),ForeignKey(nameof(Client))]
    public long ToId { get; set; }
}