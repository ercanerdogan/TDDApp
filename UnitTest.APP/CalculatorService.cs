using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.APP
{
    public class CalculatorService : ICalculatorService
    {
        public int add(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }

            return a + b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }
    }
}
