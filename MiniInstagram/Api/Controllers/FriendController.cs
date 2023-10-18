using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniInstagram.Domain.Dtos;
using MiniInstagram.Domain.Entity;
using MiniInstagram.Domain.Exceptions;
using MiniInstagram.Interface;


namespace MiniInstagram.Controllers;

[ApiController, Route("[controller]")]
public class FriendController : ControllerBase
{
    private readonly IFriendService _friendService;
    private readonly IFriendRepository _friendRepository;

    public FriendController(IFriendService friendService, IFriendRepository friendRepository)
    {
        _friendService = friendService;
        _friendRepository = friendRepository;
    }

    [HttpGet("get-friends-active"), Authorize]
    public async ValueTask<ApiResult<IEnumerable<Friend>>> GetFriendsActiveAsync(long userId)
    {
        return ApiResult<Friend>.FromIEnumerable(await _friendService.GetFriendsActiveAsync(userId));
    }

    [HttpGet("get-friends"), Authorize]
    public async ValueTask<ApiResult<IEnumerable<Friend>>> GetFriendsAsync(long userId)
    {
        return ApiResult<Friend>.FromIEnumerable(await _friendService.GetFriendsAsync(userId));
    }

    [HttpGet("get-friend"), Authorize]
    public async ValueTask<ApiResult<Friend>> GetFriendAsync(FriendDto dto)
    {
        return await _friendService.GetFriendAsync(dto);
    }

    [HttpPost("accepted-friends"), Authorize]
    public async ValueTask<ApiResult<Friend>> CreateAsync(FriendDto dto)
    {
        return await _friendService.CreateAsync(dto);
    }

    [HttpPost("block-friends"), Authorize]
    public async ValueTask<ApiResult<Friend>> BlockFriendsAsync(FriendDto dto)
    {
        return await _friendService.BlockFriendsAsync(dto);
    }

    [HttpPost("requested-friends"), Authorize]
    public async ValueTask<ApiResult<Friend>> RequestFriendsAsync(FriendDto dto)
    {
        return await _friendService.RequestFriendsAsync(dto);
    }

    [HttpPost("rejected-friends"), Authorize]
    public async ValueTask<ApiResult<Friend>> RejectedFriendsAsync(FriendDto dto)
    {
        return await _friendService.RejectedFriendsAsync(dto);
    }

    [HttpDelete("{id:long}"), Authorize]
    public async ValueTask<ApiResult<Friend>> DeleteAsync(long id)
    {
        var friend = await _friendRepository.GetByIdAsync(id);
        if (friend is null)
            throw new CustomException(404, "friend not found");
        return await _friendRepository.DeleteAsync(friend.Id);
    }
}