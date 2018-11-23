using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace testing1_1
{  
    [TestFixture]
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Divide(int numerator,int demoninator)
        {
            int result = numerator / demoninator;
            return result;
        }


    }
}
