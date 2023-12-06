using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 3, 5, 9)] //Add test data <-------
        [InlineData(7, 5, 5, 17)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var calculator = new Calculator(); 


            //Act
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]//Add test data <-------
        [InlineData(7, 1, 6)]//Add test data <-------
        [InlineData(9, 5, 4)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator(); 

            //Act
            var actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 4, 8)]//Add test data <-------
        [InlineData(1, 6, 6)]//Add test data <-------
        [InlineData(2, 2, 4)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator(); 
            //Act
            var actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        [InlineData(5, 1, 5)]//Add test data <-------
        [InlineData(6, 3, 2)]//Add test data <-------
        public void DivideTest(int divisor, int dividend, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Divide(divisor, dividend); 
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
