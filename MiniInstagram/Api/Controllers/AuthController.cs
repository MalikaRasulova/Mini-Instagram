using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniInstagram.Domain.Dtos;
using MiniInstagram.Domain.Entity;
using MiniInstagram.Interface;

namespace MiniInstagram.Controllers;

[ApiController, Route("[controller]")]
public class AuthController
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login"), AllowAnonymous]
    public async ValueTask<string> LoginAsync(LoginDto dto)
    {
        return await _authService.LoginAsync(dto);
    }

    [HttpPost("registration"), AllowAnonymous]
    public async ValueTask<ApiResult<User>> RegistrationAsync(RegistrationDto dto)
    {
        return await _authService.RegistrationAsync(dto);
    }
}