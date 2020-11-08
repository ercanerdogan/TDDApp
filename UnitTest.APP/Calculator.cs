using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.APP
{
    public class Calculator
    {
        public int add(int a, int b)
        {
            if(a==0 || b == 0)
            {
                return 0;
            }

            return a + b;
        }
    }
}
