
using MiniInstagram.Domain.Entity;
using MiniInstagram.Infrastructure;
using MiniInstagram.Interface;

public class PhotoRepository : RepositoryBase<Photo, Guid> , IPhotoRepository
{
    public PhotoRepository(DataContext context) : base(context)
    {
    }
}