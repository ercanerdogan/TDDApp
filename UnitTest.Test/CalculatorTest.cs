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



    }
}
