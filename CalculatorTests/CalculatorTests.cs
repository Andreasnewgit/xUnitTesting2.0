using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit.Sdk;
using xUnitTesting;

namespace CalculatorTests
{
    public class CalculatorTests
    {
      
       NumberHandling numberHandling = new NumberHandling();

        //[Fact]
        //// Expect to pass.
        //public void AdditionTestOne()
        //{
        //    Assert.Equal(4, numberHandling.Addition(2, 2));
        //}

        [Theory]
        [InlineData(10, 5, 2)]
        void DivisionTest(int input_1, int input_2, int expected)
        {
            int x1 = input_1;
            int x2 = input_2;
            int result = numberHandling.Division(x1, x2);

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(10, 5, 50)]
        void MultiplicationTest(int input_1, int input_2, int expected)
        {
            int x1 = input_1;
            int x2 = input_2;
            int result = numberHandling.Multiplication(x1, x2);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 2, 0)]
        void SubtractionTest(int input_1, int input_2, int expected)
        {
            int x1 = input_1;
            int x2 = input_2;
            int result = numberHandling.Subtraction(x1, x2);

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(2, 2, 4)]
        void AdditionTest(int input_1, int input_2, int expected)
        {
            int x1 = input_1;
            int x2 = input_2;          
            int result = numberHandling.Addition(x1, x2);

            Assert.Equal(expected, result);
        }

        //[Theory]
        //[InlineData(40, 8, 5)]
        //void Divide(int value1, int value2, int value3)
        //{
        //    //arrange
        //    int x1 = value1;
        //    int x2 = value2;
        //    int expected = value3;

        //    //act
        //    int actual = numberHandling.Division(x1, x2);

        //    //assert
        //    Assert.Equal(expected, actual, 0);
        //}



    }
}