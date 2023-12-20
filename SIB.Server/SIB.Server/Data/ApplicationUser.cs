using Microsoft.AspNetCore.Identity;

namespace SIB.Server.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateTime DateOfRegistration { get; set; } = DateTime.Now;
    }

}
