using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace testing1_1
{
    [TestFixture]
    class NunitTest
    {
        [TestCase]
        public void Add()
        {
            Calculator math = new Calculator();
            Assert.AreEqual(36, math.Add(25, 11));
        }

        [TestCase]
        public void Sub()
        {
            Calculator math1 = new Calculator();
            Assert.AreEqual(20, math1.Sub(30, 10));
        }
        [TestCase]
        public void  Divide()
        {
            int expected = 5;
            Calculator c1 = new Calculator();
            int actual=c1.Divide(10,2);
            Assert.AreEqual(expected, actual);
        }






    }
}
