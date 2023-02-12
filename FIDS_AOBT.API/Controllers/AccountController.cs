using FIDS_AOBT.API.Models;
using FIDS_AOBT.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FIDS_AOBT.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountRepository _accountRepository;

    public AccountController(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    [HttpPost("SignUp")]
    public async Task<IActionResult> SignUp(SignUpModel signUpModel)
    {
        var result = await _accountRepository.SignUpAsync(signUpModel);
        if(result.Succeeded)
        {
            return Ok(result.Succeeded);
        }
        return Unauthorized();
    }

    [HttpPost("SignIn")]
    public async Task<IActionResult> SignIn(SignInModel signInModel)
    {
        var result = await _accountRepository.SignInAsync(signInModel);
        if (string.IsNullOrEmpty(result))
        {
            return Unauthorized();
        }
        return Ok(result);
    }
}
