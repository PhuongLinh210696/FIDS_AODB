using FIDS_AOBT.API.Models;
using Microsoft.AspNetCore.Identity;

namespace FIDS_AOBT.API.Repositories;

public interface IAccountRepository
{
    public Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
    public Task<string> SignInAsync(SignInModel signInModel);
}
