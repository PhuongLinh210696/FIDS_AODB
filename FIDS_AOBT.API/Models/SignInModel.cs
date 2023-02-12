using System.ComponentModel.DataAnnotations;

namespace FIDS_AOBT.API.Models;

public class SignInModel
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }

}
