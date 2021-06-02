using Microsoft.AspNetCore.Mvc;
using Moq;
using RRBL;
using RRModels;
using RRWebUI.Controllers;
using RRWebUI.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RRTests
{
    public class RestaurantControllerTest
    {
    //     [Fact]
    //     public void RestaurantControllerIndexShouldReturnList()
    //     {
    //         //Arrange
    //         var mockBL = new Mock<ILocationBL>();
    //         mockBL.Setup(x => x.GetAllLocations()).Returns(
    //             new List<Location>()
    //             {
    //                 new Location("Whataburger", "Dallas", "Texas"),
    //                 new Location("In n Out", "Hayward", "California")
    //             }
    //             );
    //         var controller = new RestaurantController(mockBL.Object);
    //         //Act
    //         var result = controller.Index();
    //         //Assert
    //         //Check that we're getting a view as a result
    //         var viewResult = Assert.IsType<ViewResult>(result);
    //         //Check that the model of the viewResult is a list of restaurant VMs
    //         var model = Assert.IsAssignableFrom<IEnumerable<LocationVM>>(viewResult.ViewData.Model);
    //         //Check that we're getting the same amount of restaurants that we're returning
    //         Assert.Equal(2, model.Count());
    //     }
    // }
}