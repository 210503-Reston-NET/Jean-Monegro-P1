using Moq;
using RRBL;
using RRDL;
using RRModels;
using System.Collections.Generic;
using Xunit;

namespace RRTests
{
    public class ReviewBLTest
    {
        [Fact]
        public void GetReviewsShouldReturnAverage()
        {
            //Arrange
            // Create a stub of the IRepository

            var mockRepo = new Mock<IRepository>();
            mockRepo.Setup(x => x.GetReviews(It.IsAny<Location>())).Returns
                (
                    new List<Review>()
                    {
                        new Review("5", "Really good description", 5, 5, "hi", 545),
                        new Review("8", "Terrible", 8, 3, "hi", 7)
                    }

                );
            //Build a reviewBL object, with the stub as a dependency
            var reviewBL = new ReviewBL(mockRepo.Object);

            //Act
            var result = reviewBL.GetReviews(new Location());

            //Assert
            // Asserting that given the test input, the average should be five
            Assert.Equal(5, result.Item2);
        }
    }
}