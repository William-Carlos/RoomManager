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
            builder.HasOne(d => d.Room).WithMany().HasForeignKey(d => d.RoomId);
        }
    }
}
