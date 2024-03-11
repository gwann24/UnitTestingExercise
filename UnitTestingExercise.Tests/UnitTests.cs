using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 1, 1, 3)]
        [InlineData(9, 9, 2, 20)]
        [InlineData(2, 4, 8, 14)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var helper = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = helper.Add(num1, num2, num3);

            //Assert
            //throw new NotImplementedException();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]//Add test data <-------
        [InlineData(10, 8, 2)]
        [InlineData(9, 1, 8)]
        [InlineData(3, 4, -1)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var helper = new Calculator();

            //Act
            var actual = helper.Subract(minuend, subtrhend);

            //Assert
            //throw new NotImplementedException();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 10)]//Add test data <-------
        [InlineData(5, 5, 25)]
        [InlineData(9, 1, 9)]
        [InlineData(3, -4, -12)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var helper = new Calculator();

            //Act
            var actual = helper.Multiply(num1, num2);

            //Assert
            //throw new NotImplementedException();
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 2, 5)]//Add test data <-------
        [InlineData(5, 5, 1)]
        [InlineData(9, 3, 3)]
        [InlineData(3, -1, -3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var helper = new Calculator();

            //Act
            var actual = helper.Divide(num1, num2);

            //Assert
            //throw new NotImplementedException();
            Assert.Equal(expected, actual);

        }

    }
}
