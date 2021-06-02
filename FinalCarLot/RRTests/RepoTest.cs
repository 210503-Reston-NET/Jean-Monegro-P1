using Microsoft.EntityFrameworkCore;
using RRDL;
using RRModels;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RRTests
{
    //When unit testing DBs, note that you need to install the Microsoft.EntityFrameworkCore.Sqlite package
    //Sqlite has features that allows you to create an inmemory rdb.

    /// <summary>
    /// This is going to be my test class for the data access methods in my repo
    // /// </summary>
    // public class RepoTest
    // {
    //     private readonly DbContextOptions<RestaurantDBContext> options;

    //     //Xunit creates new instances of test classes, you need to make sure that you seed your db for each class
    //     public RepoTest()
    //     {
    //         options = new DbContextOptionsBuilder<RestaurantDBContext>().UseSqlite("Filename=Test.db").Options;
    //         Seed();
    //     }

    //     //Test Read Ops
    //     //When testing methods that do not state of the data in the db only one context instance is needed
    //     //What methods does not affect db state: Read
    //     [Fact]
    //     public void GetAllRestaurantsShouldReturnAllRestaurants()
    //     {
    //         //putting in a test context/ connection to our test db
    //         using (var context = new RestaurantDBContext(options))
    //         {
    //             //Arrange
    //             IRepository _repo = new RepoDB(context);

    //             //Act
    //             var locations = _repo.GetAllLocations();

    //             //Assert
    //             Assert.Equal(2, locations.Count);
    //         }
    //     }

    //     //When testing operations that change the state of the db (i.e manipulate the data inside the db)
    //     //make sure to check if the change has persisted even when accessing the db using a different context/connection
    //     //This means that you create another instance of your context when testing to check that the method has
    //     //definitely affected the db.
    //     //What operations affect the state of the db? Create, Update, Delete
    //     [Fact]
    //     public void AddRestaurantShouldAddRestaurant()
    //     {
    //         using (var context = new RestaurantDBContext(options))
    //         {
    //             IRepository _repo = new RepoDB(context);
    //             //Act with a test context
    //             _repo.AddLocation
    //             (
    //                 new Location("Whataburger", "Dallas", "TX")
    //             );
    //         }
    //         //use a diff context to check if changes persist to db
    //         using (var assertContext = new RestaurantDBContext(options))
    //         {
    //             //Assert with a different context
    //             var result = assertContext.Locations.FirstOrDefault(location => location.Id == 3);
    //             Assert.NotNull(result);
    //             Assert.Equal("Dallas", result.City);
    //         }
    //     }

    //     private void Seed()
    //     {
    //         //this is an exmaple of a using block
    //         using (var context = new RestaurantDBContext(options))
    //         {
    //             //This makes sure that the state of the db gets recreated everytime to maintain modularity of tests
    //             context.Database.EnsureDeleted();
    //             context.Database.EnsureCreated();
    //             context.Locations.AddRange
    //             (
    //                 new Location
    //                 {
    //                     Id = 1,
    //                     City = "Good Taste",
    //                     State = "Baguio City",
    //                     Country = "Benguet",
    //                     Reviews = new List<Review>
    //                     {
    //                         new Review
    //                         {
    //                             ReviewId = 1,
    //                             Mpg = 5,
    //                             Desc = "This was good"
    //                         },
    //                         new Review
    //                         {
    //                             ReviewId = 2,
    //                             Mpg = 7,
    //                             Desc = "Pretty cool"
    //                         }
    //                     }
    //                 },
    //                 new Location
    //                 {
    //                     Id = 2,
    //                     City = "Maru Sushi",
    //                     State = "Kalamazoo",
    //                     Country = "Michigan",
    //                     Reviews = new List<Review>
    //                     {
    //                         new Review
    //                         {
    //                             ReviewId = 3,
    //                             Mpg = 5,
    //                             Desc = "This was good sushi"
    //                         },
    //                         new Review
    //                         {
    //                             ReviewId = 4,
    //                             Mpg = 5,
    //                             Desc = "Pretty cool sushi"
    //                         }
    //                     }
    //                 }
    //             );
    //             context.SaveChanges();
    //         }
    //     }
    // }
}