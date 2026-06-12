

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { 
            
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Cabin> Cabins  { get; set; }
        public DbSet<Setting> Settings {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().Property(x => x.CabinPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Booking>().Property(x => x.ExtrasPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Booking>().Property(x => x.TotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Cabin>().Property(x => x.RegularPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Setting>().Property(x => x.BreakfastPrice).HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
