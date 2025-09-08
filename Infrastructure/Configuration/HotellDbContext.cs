using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

public class HotelDbContext : DbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new RoomConfiguration());
        modelBuilder.ApplyConfiguration(new BookingConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
    }
}
