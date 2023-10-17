using Microsoft.EntityFrameworkCore;
using MiniInstagram.Entity;
using MiniInstagram.Interface;

namespace MiniInstagram.Infrastructure.Repository;

public class FriendRepository :BaseRepository<Friends>, IFriendRepository
{
    public FriendRepository(DbContext context) : base(context)
    {
    }
}