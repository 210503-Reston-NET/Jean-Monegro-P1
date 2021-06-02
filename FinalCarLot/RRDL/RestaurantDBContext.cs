using Microsoft.EntityFrameworkCore;
using RRModels;

namespace RRDL
{
    public class RestaurantDBContext : DbContext
    {
        public RestaurantDBContext() : base()
        {
        }
        public RestaurantDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Location> Locations { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
            .Property(location => location.Id)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Review>()
            .Property(review => review.ReviewId)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>()
            .Property(customer => customer.CustomerId)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Order>()
            .Property(order => order.OrderId)
            .ValueGeneratedOnAdd();
        }
    }
}