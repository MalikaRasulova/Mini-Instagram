using Microsoft.EntityFrameworkCore;
using MiniInstagram.Entity;
using MiniInstagram.Interface;

namespace MiniInstagram.Infrastructure.Repository;

public class UserRepository :  BaseRepository<User> ,IUserRepository
{
    public UserRepository(DbContext context) : base(context)
    {
    }
}