using LogInPage.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogInPage.Areas.Identity.Data;

public class DBLogInPageContext : IdentityDbContext<LogUser>
{
    public DBLogInPageContext(DbContextOptions<DBLogInPageContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserIntityConfiguration());
    }
}
public class ApplicationUserIntityConfiguration : IEntityTypeConfiguration<LogUser>
{
    public void Configure(EntityTypeBuilder<LogUser> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(100);
        builder.Property(x => x.LastName).HasMaxLength(100);

    }
}
