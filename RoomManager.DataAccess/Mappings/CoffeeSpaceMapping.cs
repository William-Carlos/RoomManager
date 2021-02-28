using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomManager.Domain.Entities;

namespace RoomManager.DataAccess.Mappings
{
    public class CoffeeSpaceMapping : IEntityTypeConfiguration<CoffeeSpace>
    {
        public void Configure(EntityTypeBuilder<CoffeeSpace> builder)
        {
            builder.Property(d => d.Name).HasColumnName("Name").IsRequired();
        }
    }
}
