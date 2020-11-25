using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.APP
{
    public class Calculator
    {
        private readonly ICalculatorService _calculatorService;

        public Calculator(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;

        }
        public int add(int a, int b)
        {
            return _calculatorService.add(a, b);
        }


        public int multiply(int a, int b)
        {
            return _calculatorService.multiply(a, b);

        }
    }
}
