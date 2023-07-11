using Imi.Project.Api.Core.Interfaces.IServices;
using Imi.Project.Api.Dtos.Accounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {

        private readonly IUserService _userService;

        public AccountsController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AccountsLoginRequestDto accountsLoginRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var result = await _userService.Login(accountsLoginRequestDto.Email,
                accountsLoginRequestDto.Password);
            if (result.Success)
            {
                return Ok(new AccountsLoginResponseDto { Token = result.Messages.First() });
            }
            return Unauthorized(result.Messages);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register(AccountsRegisterRequestDto registrationDto)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            var result = await _userService.Register(
                registrationDto.UserName,
                registrationDto.Email,
                registrationDto.Password,
                registrationDto.BirthDate,
                registrationDto.HasAcceptedTermsAndConditions
                );
            if (!result.Success)
            {
                return BadRequest(result.Messages);
            }
            return Ok(result.Messages);
        }
    }
}



