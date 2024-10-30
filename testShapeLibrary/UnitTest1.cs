using ShapeLibrary;
namespace testShapeLibrary
{
    public class UnitTest1
    {
        [Fact]
        public void Triangle_Area_Calculated_Correctly()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6.0;

            // Act
            double actualArea = triangle.Area;

            // Assert
            Assert.Equal(expectedArea, actualArea); 
        }

        [Fact]
        public void Circle_Area_Calculated_Correctly()
        {
            // Arrange

            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            // Act
            double actualArea = circle.Area;

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }
    }
}