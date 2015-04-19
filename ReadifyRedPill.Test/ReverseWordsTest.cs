using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReadifyRedPill.Test
{
    [TestClass]
    public class ReverseWordsTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWordsTest1()
        {
            MyRedPill redPill = new MyRedPill();
            redPill.ReverseWords(null);
        }

        [TestMethod]
        public void ReverseWordsTest2()
        {
            MyRedPill redPill = new MyRedPill();
            string result = redPill.ReverseWords("arman");
            Assert.AreEqual(result, "namra");
        }

        [TestMethod]
        public void ReverseWordsTest3()
        {
            MyRedPill redPill = new MyRedPill();
            string result = redPill.ReverseWords("arman najafi");
            Assert.AreEqual(result, "namra ifajan");
        }

        [TestMethod]
        public void ReverseWordsTest4()
        {
            MyRedPill redPill = new MyRedPill();
            string result = redPill.ReverseWords("arm!an najafi.");
            Assert.AreEqual(result, "na!mra .ifajan");
        }
    }
}
