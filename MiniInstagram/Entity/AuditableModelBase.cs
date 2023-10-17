using System.ComponentModel.DataAnnotations.Schema;
using PictureSharing.Entity;

namespace MiniInstagram.Entity;

public class AuditableModelBase : BaseModel
{
    [Column("created_at")] 
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Column("updated_at")] 
    public DateTime? UpdatedAt { get; set; }
  
}