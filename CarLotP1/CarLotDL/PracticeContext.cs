using Microsoft.EntityFrameworkCore;
using CarLotModels;

#nullable disable

namespace CarLotDL
{
    public partial class PracticeContext : DbContext
    {
        public PracticeContext()
        {
        }

        public PracticeContext(DbContextOptions options)
            : base(options)
        {
        }

        public  DbSet<Car> Cars { get; set; }
        public  DbSet<Description> Descriptions { get; set; }
        public  DbSet<Location> Locations { get; set; }
        public  DbSet<Customer> Customers { get; set; }
        public  DbSet<Orders> Orders { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
            .Property(location => location.LocationId)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Car>()
            .Property(car => car.CarId)
            .ValueGeneratedOnAdd(); 
            modelBuilder.Entity<Description>()
            .Property(description => description.DescriptionId)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Orders>()
            .Property(order => order.OrderId)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>()
            .Property(customer => customer.CustomerId)
            .ValueGeneratedOnAdd();
        }
    }
}

