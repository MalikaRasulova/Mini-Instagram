using Microsoft.EntityFrameworkCore;
using MiniInstagram.Interface;
using PictureSharing.Entity;

namespace MiniInstagram.Infrastructure.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
{
    private readonly DbContext _context;

    public BaseRepository(DbContext context)
    {
        _context = context;
    }
    public DbSet<T> DbGetSet()
    {
        return _context.Set<T>();
    }

    public async ValueTask<IEnumerable<T>> GetAllAsync()
    {
        return await DbGetSet().ToListAsync();
    }

    public async ValueTask<T> GetByIdAsync(long id)
    {
        var data = await DbGetSet()
            .FirstOrDefaultAsync(x => x.Id == id);
        if (data is null)
        {
            throw new Exception("DATA NOT FOUNT");
        }

        return data;
    }

    public async ValueTask<T> CreatAsync(T data)
    {
        var result = DbGetSet().Add(data);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async ValueTask<T> UpdateAsync(T data)
    {
        var result = DbGetSet().Update(data);
        await _context.SaveChangesAsync();
        return result.Entity;
    }
    
    public async ValueTask<T> RemoveAsync(long id)
    {
        var entity = await GetByIdAsync(id);
        var entityResult = DbGetSet().Remove(entity);
        await _context.SaveChangesAsync();
        return entityResult.Entity;
    }
}