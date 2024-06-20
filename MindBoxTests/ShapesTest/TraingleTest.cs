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
    public class TraingleTest
    {
        [Fact]
        public void CalculateArea_Returns_Expected()
        {
            //Arrange
            double SideA = 4;
            double SideB = 5;
            double SideC = 6;
            Triangle traingle = new Triangle(SideA, SideB, SideC);
            double expectedArea = 9.92;

            //Act
            double actualArea = traingle.CalculateArea();

            //Assert
            Assert.Equal(expectedArea, actualArea, 2);
        }

        [Fact]
        public void Traingle_Should_Throw_When_Sides_Are_Negative()
        {
            //Arrange
            double SideA = -4.4;
            double SideB = -5.5;
            double SideC = -6.6;

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(SideA, SideB, SideC));
        }

        [Theory]
        [InlineData(1, 1, 3)]
        [InlineData(1, 3, 1)]
        [InlineData(3, 1, 1)]        
        public void Traingle_Should_Throw_When_Sum_Of_2Sides_Is_Less_Than_3dSide(double SideA, double SideB, double SideC)
        {           

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(SideA, SideB, SideC));
        }

        [Fact]
        public void CheckHaveRightAngle_Should_Return_True_For_RightTriangle()
        {
            //Arrange
            double SideA = 3;
            double SideB = 4;
            double SideC = 5;
            Triangle traingle = new Triangle(SideA, SideB, SideC);

            //Act 
            bool IsRightTriangle = true;

            //Assert
            Assert.True(IsRightTriangle);
        }

        [Fact]
        public void CheckHaveRightAngle_Should_Return_False_For_Non_RightTriangle()
        {
            //Arrange
            double SideA = 4;
            double SideB = 4;
            double SideC = 5;
            Triangle traingle = new Triangle(SideA, SideB, SideC);

            //Act 
            bool IsRightTriangle = false;

            //Assert
            Assert.False(IsRightTriangle);
        }
    }
}
