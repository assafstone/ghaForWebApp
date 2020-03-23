using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using webapp.Controllers;
using Xunit;

namespace webapp.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Index()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<HomeController>>();
            
            var target = new HomeController(mockLogger.Object);

            // Act
            var result = target.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}
