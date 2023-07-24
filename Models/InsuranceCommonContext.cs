using Microsoft.EntityFrameworkCore;

namespace cursodotnet.Models
{
    public class InsuranceCommonContext : DbContext
    {
        public DbSet<EntityApi> Api { get; set; } = null!;
        public InsuranceCommonContext(DbContextOptions<InsuranceCommonContext> options) : base(options) { }
    }
}