using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReadifyRedPill.Test
{
    [TestClass]
    public class FibonacciNumberTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FibonacciNumberTest1()
        {
            MyRedPill redPill = new MyRedPill();
            redPill.FibonacciNumber(93);
        }

        [TestMethod]
        public void FibonacciNumberTest2()
        {
            MyRedPill redPill = new MyRedPill();
            long result = redPill.FibonacciNumber(0);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void FibonacciNumberTest3()
        {
            MyRedPill redPill = new MyRedPill();
            long result = redPill.FibonacciNumber(3);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void FibonacciNumberTest4()
        {
            MyRedPill redPill = new MyRedPill();
            long result = redPill.FibonacciNumber(-1);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void FibonacciNumberTest5()
        {
            MyRedPill redPill = new MyRedPill();
            long result = redPill.FibonacciNumber(-2);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FibonacciNumberTest6()
        {
            MyRedPill redPill = new MyRedPill();
            long result = redPill.FibonacciNumber(-93);
        }
    }
}
