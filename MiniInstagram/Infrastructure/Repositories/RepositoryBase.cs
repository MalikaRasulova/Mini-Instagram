using Microsoft.EntityFrameworkCore;
using MiniInstagram.Domain;
using MiniInstagram.Domain.Exceptions;
using MiniInstagram.Infrastructure;
using MiniInstagram.Interface;

public class RepositoryBase<T, TId> : IBaseRepository<T, TId> where T : BaseModel<TId>
{
    private readonly DataContext _context;

    public RepositoryBase(DataContext context)
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

    public async ValueTask<T> GetByIdAsync(TId id)
    {
        var data = await DbGetSet().FirstOrDefaultAsync(x => x.Id.Equals(id));
        if (data is null)
            throw new CustomException(404,"Data not fount");
        return data;
    }

    public async ValueTask<T> CreatAsync(T data)
    {
        var entityResult = DbGetSet().Add(data);
        await _context.SaveChangesAsync();
        return entityResult.Entity;
    }

    public async ValueTask<T> UpdateAsync(T data)
    {
        var entityResult = DbGetSet().Update(data);
        await _context.SaveChangesAsync();
        return entityResult.Entity;
    }

    public async ValueTask<T> DeleteAsync(TId id)
    {
        var data = await GetByIdAsync(id);
        var entityResult = DbGetSet().Remove(data);
        await _context.SaveChangesAsync();
        return entityResult.Entity;
    }
}