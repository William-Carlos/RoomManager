using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomManager.Domain.Entities;

namespace RoomManager.DataAccess.Mappings
{
    public class PersonMapping : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(d => d.Name).HasColumnName("Name").IsRequired();
            builder.Property(d => d.LastName).HasColumnName("LastName").IsRequired();
            builder.HasOne(d => d.FirstStepRoom).WithMany().HasForeignKey(d => d.FirstStepRoomId);
            builder.HasOne(d => d.SecondStepRoom).WithMany().HasForeignKey(d => d.SecondStepRoomId);
            builder.HasOne(d => d.FirstStepCoffeeSpace).WithMany().HasForeignKey(d => d.FirstStepCoffeeSpaceId);
            builder.HasOne(d => d.SecondStepCoffeeSpace).WithMany().HasForeignKey(d => d.SecondStepCoffeeSpaceId);
        }
    }
}
