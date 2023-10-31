using LandsApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LandsApplication.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<AgreementLease> AgreementLeases { get; set; }

        public DbSet<PurchaseOption> PurchaseOptions { get; set; }

        public DbSet<Application> Application { get; set; }
    }
}
