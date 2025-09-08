using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Number).IsRequired().HasMaxLength(10);
        builder.Property(r => r.PricePerNight).HasColumnType("decimal(18,2)");
    }
}
