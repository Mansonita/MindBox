using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBox.Interfaces;
using MindBox.Shapes;
using Xunit;

namespace MindBoxTests.ShapesTest
{
    public class CircleTest
    {
        [Fact]
        public void CalculateArea_Returns_Expected()
        {
            //Arrange
            double radius = 7;
            IShape circle = new Circle(radius);
            double expectedArea = 153.938;

            //Act
            double actualArea = circle.CalculateArea();

            //Assert
            Assert.Equal(expectedArea, actualArea,3); // Из-за природы числа P нет смысла сравнивать целиком значение
        }


        [Fact]
        public void Circle_Should_Throw_When_Radius_Is_Negative()
        {
            // Arrange
            double radius = -7;

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }
    }
}
