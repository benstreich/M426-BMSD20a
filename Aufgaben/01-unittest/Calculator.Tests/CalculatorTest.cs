using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void TestMultiplicateFourTimesTwoIsEight()
        {
            // Given
            int a = 4;
            int b = 2;
            int expected = 8;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.multiplicate(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideTwentyfourDividedbySixIsFour()
        {
            // Given
            int a = 24;
            int b = 6;
            int expected = 4;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.divide(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideByZeroException()
        {
            // Given
            int a = 24;
            int b = 0;
            int expected = 3;
            Calculator calculator = new Calculator();

            // When
            int actual;
            // Then
            Assert.Throws<DivideByZeroException>(() =>

             actual = calculator.divide(a, b)

            );
            
        }
    }
}
