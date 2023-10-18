
using MiniInstagram.Domain.Entity;
using MiniInstagram.Interface;


namespace MiniInstagram.Infrastructure.Repository;

public class UserRepository : RepositoryBase<User, long>, IUserRepository
{
    public UserRepository(DataContext context) : base(context)
    {
    }
}