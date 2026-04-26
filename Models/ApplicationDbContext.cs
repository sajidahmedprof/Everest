using Microsoft.EntityFrameworkCore;

namespace Everest.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CompanyProfile> CompanyProfiles { get; set; }
    }
}
