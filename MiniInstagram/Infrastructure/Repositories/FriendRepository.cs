using MiniInstagram.Domain.Entity;
using MiniInstagram.Infrastructure;
using MiniInstagram.Interface;


public class FriendRepository : RepositoryBase<Friend, long>, IFriendRepository 
{
    public FriendRepository(DataContext context) : base(context)
    {
    }
}