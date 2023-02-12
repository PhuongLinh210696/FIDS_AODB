using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FIDS_AOBT.API.Data;

public class FidsAobtContext:IdentityDbContext<ApplicationUser>
{
    public FidsAobtContext(DbContextOptions<FidsAobtContext> options) : base(options) { }

    #region DbSet
    public DbSet<CheckinViewTemplate> CheckinViewTemplates { get; set; }
    #endregion
}
