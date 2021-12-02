using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleConsoleAppForModuleTesting.Tests
{
    public class MethodsTests
    {
        private readonly Methods methods;

        public MethodsTests()
        {
            methods = new Methods();
        }

        [Fact]
        public void Sum_ShouldWork()
        {
            //Arrange
            double expected = 10;

            //Act
            double actual = methods.Sum(2, 8);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Difference_ShouldWork()
        {
            //Arrange
            double expected = 4;

            //Act
            double actual = methods.Difference(10, 6);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 5, 4)]
        public void Devision_ShouldWork(double a, double b, double expected)
        {
            //Arrange

            //Act
            double actual = methods.Devision(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 5, 15)]
        public void Multiplication_ShouldWork(double a, double b, double expected)
        {
            //Arrange

            //Act
            double actual = methods.Multiplication(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Sum_ShouldNotWork()
        {
            //Arrange
            double expected = 15;

            //Act
            double actual = methods.Sum(2, 8);

            //Assert
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void Difference_ShouldNotWork()
        {
            //Arrange
            double expected = 18;

            //Act
            double actual = methods.Sum(10, 6);

            //Assert
            Assert.NotEqual(expected, actual);
        }

        [Theory]
        [InlineData(25, 5, 4)]
        public void Devision_ShouldNotWork(double a, double b, double expected)
        {
            //Arrange

            //Act
            double actual = methods.Sum(a, b);

            //Assert
            Assert.NotEqual(expected, actual);
        }

        [Theory]
        [InlineData(3, 7, 15)]
        public void Multiplication_ShouldNotWork(double a, double b, double expected)
        {
            //Arrange

            //Act
            double actual = methods.Sum(a, b);

            //Assert
            Assert.NotEqual(expected, actual);
        }
    }
}
