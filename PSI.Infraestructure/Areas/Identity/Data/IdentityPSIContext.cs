using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PSI.Infraestructure.Areas.Identity.Data;

namespace PSI.Infraestructure.Areas.Identity.Data;

public class IdentityPSIContext : IdentityDbContext<PSIUser>
{
    public IdentityPSIContext(DbContextOptions<IdentityPSIContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
