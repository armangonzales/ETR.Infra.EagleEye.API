using ETR.Infra.EagleEye.API.Model;
using Microsoft.EntityFrameworkCore;

namespace ETR.Infra.EagleEye.API.Data
{
    public class PulseDbContext : DbContext
    {
        public PulseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<PulseLog> PulseLogs { get; set; }
    }
}
