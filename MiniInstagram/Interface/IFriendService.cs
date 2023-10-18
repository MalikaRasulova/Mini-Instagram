

using MiniInstagram.Domain.Dtos;
using MiniInstagram.Domain.Entity;

namespace MiniInstagram.Interface;

public interface IFriendService
{
    public ValueTask<IEnumerable<Friend>> GetFriendsActiveAsync(long userId);
    public ValueTask<IEnumerable<Friend>> GetFriendsAsync(long userId);
    public ValueTask<Friend> GetFriendAsync(FriendDto dto);
    public ValueTask<Friend> CreateAsync(FriendDto dto);
    public ValueTask<Friend> BlockFriendsAsync(FriendDto dto);
    public ValueTask<Friend> RequestFriendsAsync(FriendDto dto);
    public ValueTask<Friend> RejectedFriendsAsync(FriendDto dto);
}