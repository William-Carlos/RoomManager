using Microsoft.EntityFrameworkCore;
using RoomManager.DataAccess.Mappings;

namespace RoomManager.DataAccess.Context
{
    public class ManagerRoomContext : DbContext
    {
        public ManagerRoomContext() { }

        public ManagerRoomContext(DbContextOptions<ManagerRoomContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoomMapping());
            modelBuilder.ApplyConfiguration(new PersonMapping());
            modelBuilder.ApplyConfiguration(new CoffeeSpaceMapping());
        }
    }
}
