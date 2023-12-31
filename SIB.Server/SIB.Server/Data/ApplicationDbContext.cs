using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Reflection.Emit;

namespace SIB.Server.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedRoles(builder);
            this.SeedOwner(builder);
            this.SeedArticles(builder);
        }

        public DbSet<Article> Articles { get; set; }

        private void SeedArticles(ModelBuilder builder)
        {
            builder.Entity<Article>()
                .HasOne(p => p.User)
                .WithMany(p => p.Articles);
        }
        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                    new IdentityRole() { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Owner", ConcurrencyStamp = "1", NormalizedName = "Owner".ToUpper()},
                    new IdentityRole() { Name = "Admin", ConcurrencyStamp = "2", NormalizedName = "Admin".ToUpper() },
                    new IdentityRole() { Name = "Moderator", ConcurrencyStamp = "3", NormalizedName = "Moderator".ToUpper()},
                    new IdentityRole() { Name = "Creator", ConcurrencyStamp = "4", NormalizedName = "Creator".ToUpper() }
                );
        }
        private void SeedOwner(ModelBuilder builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(
                    new ApplicationUser
                    {
                        Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                        UserName = "Owner@owner.com",
                        NormalizedUserName = "Owner@owner.com".ToUpper(),
                        Email = "Owner@owner.com",
                        NormalizedEmail = "OWNER@OWNER.COM".ToUpper(),
                        EmailConfirmed = true,
                        SecurityStamp = new DateTime().ToString(),
                        PasswordHash = hasher.HashPassword(null, "OURPASSWORD")
                    }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            });

            //builder.Entity<Article>()
            //    .HasData(
            //    new Article { Id = 1, User = Users.First(u => u.Id == "8e445865-a24d-4543-a6c6-9443d048cdb9"), Description = "Seeded Article", DOC = DateTime.Now, Title = "Owner's seeded article", Views = 0 }
            //);
        }

    }
}
