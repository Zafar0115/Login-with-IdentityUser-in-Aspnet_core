using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Aspnet_Core_Identity.Data
{
    public class ApplicationDbContext:IdentityDbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
    }
}
