using Microsoft.EntityFrameworkCore;
using MiniInstagram.Entity;
using MiniInstagram.Interface;

namespace MiniInstagram.Infrastructure.Repository;

public class Clientrepository : BaseRepository<Client>, IClientRepository
{
    public Clientrepository(DbContext context) : base(context)
    {
    }
}