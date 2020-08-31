using FluentAssertions;
using Moq;
using System;
using Xunit;

namespace Project101.UnitTest
{
    public class CalculationsTests
    {
        Calculations calculations;
        Mock<ILogger> mockLogger;
        Mock<IStaticClassWrapper> mockStaticClassWrapper;
        public CalculationsTests()
        {
            
        }

        [Theory]
        [InlineData(3,5,8)]
        [InlineData(3,1,4)]
        public void Add_WithValidInputs_ShouldReturnSumOfNumbers(int val1, int val2, int total)
        {
            //Arrange

            //Act
            calculations = new Calculations();
            var sum = calculations.Add(val1, val2);

            //Assert
            sum.Should().Be(total);
        }

        [Fact]
        public void Divide_DivideToZero_ShouldThrowDivideByZeroException()
        {
            //Arrange
            int val1 = 567;
            int val2 = 0;

            //Act
            calculations = new Calculations();
            Action act = () => calculations.Divide(val1, val2);

            //Assert
            act.Should().Throw<DivideByZeroException>().WithMessage("Divide By Zero ExceptionMessage");
        }


        [Fact]
        public void Multiply_SecondValIsZero_ShouldReturnZero()
        {
            //Arrange
            int val1 = 567;
            int val2 = 0;

            mockLogger = new Mock<ILogger>();

            mockLogger.Setup(x => x.Info(It.IsAny<string>())).Returns("Info stub created");

            calculations = new Calculations(mockLogger.Object);

            //Act
            var result = calculations.Multiply(val1, val2);

            //Assert
            result.Should().Be(0);

        }

        [Theory]
        //Arrange 
        [InlineData(-9, 5)]
        [InlineData(3, -1)]
        
        public void Multiply_ValuesAreNegative_ShouldReturnZero(int val1, int val2)
        {           

            mockLogger = new Mock<ILogger>();

            mockLogger.Setup(x => x.Warn(It.IsAny<string>())).Returns("Warn stub created");

            calculations = new Calculations(mockLogger.Object);

            //Act
            var result = calculations.Multiply(val1, val2);

            //Assert
            result.Should().BeLessThan(0);

        }

        [Fact]
        public void Minus_val1IsZero_ReturnValidNumber()
        {
            //Arrange
            int val1 = 0;
            int val2 = 5;

            mockStaticClassWrapper = new Mock<IStaticClassWrapper>();

            mockStaticClassWrapper.Setup(x => x.WriteMessage(It.IsAny<string>())).Returns("stub created");

            calculations = new Calculations(mockStaticClassWrapper.Object);

            //Act
            var result = calculations.Minus(val1, val2);

            //Assert
            result.Should().Be(-5);

        }



    }
}
