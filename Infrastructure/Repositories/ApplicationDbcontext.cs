using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ApartmentCon());
        modelBuilder.ApplyConfiguration(new BookingCon());
        modelBuilder.ApplyConfiguration(new ReviewCon());
        modelBuilder.ApplyConfiguration(new UserCon());
    }
}
