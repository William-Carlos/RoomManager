using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomManager.Domain.Entities;

namespace RoomManager.DataAccess.Mappings
{
    public class RoomMapping : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(d => d.Name).HasColumnName("Name").IsRequired();
            builder.Property(d => d.Capacity).HasColumnName("Capacity").IsRequired();
            builder.Property(d => d.Quantity).HasColumnName("Quantity").IsRequired();
        }
    }
}
