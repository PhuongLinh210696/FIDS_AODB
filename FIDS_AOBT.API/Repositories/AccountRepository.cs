using FIDS_AOBT.API.Data;
using FIDS_AOBT.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FIDS_AOBT.API.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly UserManager<ApplicationUser> userManager;
    private readonly SignInManager<ApplicationUser> signInManager;
    private readonly IConfiguration configuration;

    public AccountRepository(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
        this.configuration = configuration;
    }
    public async Task<string> SignInAsync(SignInModel signInModel)
    {
        var result = await signInManager.PasswordSignInAsync(signInModel.Username, signInModel.Password, false, false);
        if(!result.Succeeded)
        {
            return string.Empty;
        }

        var authClaim = new List<Claim> 
        {
           new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
        };

        var authKey =new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

        var token = new JwtSecurityToken(
            issuer: configuration["JWT:ValidIssuer"],
            audience: configuration["JWT:ValidAudience"],
            expires: DateTime.Now.AddMinutes(2),
            claims: authClaim,
            signingCredentials: new SigningCredentials(authKey, SecurityAlgorithms.HmacSha512Signature)
            );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public async Task<IdentityResult> SignUpAsync(SignUpModel signUpModel)
    {
        var user = new ApplicationUser
        {
            FirstName = signUpModel.FirstName,
            LastName = signUpModel.LastName,
            UserName = signUpModel.Username,
        };
        return await userManager.CreateAsync(user,signUpModel.Password);
    }
}
