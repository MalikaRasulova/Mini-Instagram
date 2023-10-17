using Microsoft.EntityFrameworkCore;
using MiniInstagram.Entity;
using MiniInstagram.Interface;

namespace MiniInstagram.Infrastructure.Repository;

public class PhotoRepository : BaseRepository<Photo>, IPhotoRepository
{
    public PhotoRepository(DbContext context) : base(context)
    {
    }
}