using System;
using System.Collections.Generic;
using System.Text;
using UnitTest.APP;
using Xunit;

namespace UnitTest.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            int a = 5;
            int b = 20;
            var calculator = new Calculator();

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
        [InlineData(5, 20, 25)]
        [InlineData(3, 5, 8)]
        public void TestSumWithParameter(int a, int b, int expectedTotal)
        {
            var calculator = new Calculator();

            var actualTotal = calculator.add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        }



    }
}
