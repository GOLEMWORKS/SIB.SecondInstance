using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SIB.Server.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedRoles(builder);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                    new IdentityRole() { Name = "Owner", ConcurrencyStamp = "1", NormalizedName = "Owner".ToUpper()},
                    new IdentityRole() { Name = "Admin", ConcurrencyStamp = "2", NormalizedName = "Admin".ToUpper() },
                    new IdentityRole() { Name = "Moderator", ConcurrencyStamp = "3", NormalizedName = "Moderator".ToUpper()},
                    new IdentityRole() { Name = "Creator", ConcurrencyStamp = "4", NormalizedName = "Creator".ToUpper() }
                );
        }

        //public DbSet<ApplicationUser> ApplicationUser { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    var hasher = new PasswordHasher<ApplicationUser>();

        //    builder.Entity<ApplicationUser>().HasData(
        //            new ApplicationUser
        //            {
        //                Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
        //                UserName = "Owner",
        //                NormalizedUserName = "OWNER".ToUpper(),
        //                Email = "Owner@owner.com",
        //                NormalizedEmail = "OWNER@OWNER.COM".ToUpper(),
        //                EmailConfirmed = true,
        //                SecurityStamp = new DateTime().ToString(),
        //                PasswordHash = hasher.HashPassword(null,"OURPASSWORD")
        //            }
        //        );
        //}
    }
}
