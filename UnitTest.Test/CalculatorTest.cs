using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest.APP;
using Xunit;

namespace UnitTest.Test
{
    public class CalculatorTest
    {
        public Calculator calculator { get; set; }

        public Mock<ICalculatorService> myMock { get; set; }

        public CalculatorTest()
        {
            myMock = new Mock<ICalculatorService>();
            this.calculator = new Calculator(myMock.Object);
        }
        [Fact]
        public void AddTest()
        {
            int a = 5;
            int b = 20;
            //var calculator = new Calculator();

            var total = calculator.add(a, b);

            Assert.Equal<int>(25, total);

        }


        [Fact]
        public void TestContain()
        {
            var names = new List<string>() { "Turkey", "ABD", "Germany", "Holland", "UK" };

            Assert.Contains(names, x => x == "UK");
        }

        [Fact]
        public void TestStartWith()
        {
            Assert.StartsWith("Ercan", "Ercan Erdoğan");
        }

        [Fact]
        public void TestEndWith()
        {
            Assert.StartsWith("Ercan", "Ercan Erdoğan");
        }

        [Fact]
        public void TestRange()
        {

            Assert.InRange(15, 1, 100);

        }

        [Fact]
        public void TestType()
        {

            Assert.IsType<string>("Ercan");

        }


        [Theory]
        [InlineData(0, 20, 0)]
        [InlineData(3, 0, 0)]
        public void Add_zeroValues_ReturnTotalZero(int a, int b, int expectedTotal)
        {
            var actualTotal = calculator.add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(5, 20, 25)]
        [InlineData(3, 5, 8)]
        public void Add_simpleValues_ReturnTotal(int a, int b, int expectedTotal)
        {
            myMock.Setup(x => x.add(a, b)).Returns(expectedTotal);

            var actualTotal = calculator.add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(5, 20, 100)]
        [InlineData(3, 5, 15)]

        public void Multiply_simpleValues_ReturnTotal(int a, int b, int expectedValue)
        {
            myMock.Setup(x => x.multiply(a, b)).Returns(expectedValue);

            var actualTotal = calculator.multiply(a, b);

            Assert.Equal(expectedValue, actualTotal);
        }

    }
}
