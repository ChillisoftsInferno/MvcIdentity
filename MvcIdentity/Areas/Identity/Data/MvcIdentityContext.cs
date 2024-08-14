using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcIdentity.Areas.Identity.Data;

namespace MvcIdentity.Data;

public class MvcIdentityContext : IdentityDbContext<ApplicationUser>
{
    public MvcIdentityContext(DbContextOptions<MvcIdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
