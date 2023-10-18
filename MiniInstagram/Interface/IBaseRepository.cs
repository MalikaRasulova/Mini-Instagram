using Microsoft.EntityFrameworkCore;
using MiniInstagram.Domain;

namespace MiniInstagram.Interface;

public interface IBaseRepository<T, TId> where T : BaseModel<TId>
{
    public DbSet<T> DbGetSet();
    public ValueTask<IEnumerable<T>> GetAllAsync();
    public ValueTask<T> GetByIdAsync(TId id);
    public ValueTask<T> CreatAsync(T data);
    public ValueTask<T> UpdateAsync(T data);
    public ValueTask<T> DeleteAsync(TId id);
}