using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using knockknock.readify.net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReadifyRedPill.Test
{
    [TestClass]
    public class WhatShapeIsThisTest
    {
        [TestMethod]
        public void WhatShapeIsThisTest1()
        {
            MyRedPill redPill = new MyRedPill();

            TriangleType type = redPill.WhatShapeIsThis(-1, 0, 0);
            Assert.AreEqual(type, TriangleType.Error);

            type = redPill.WhatShapeIsThis(0, -1, 0);
            Assert.AreEqual(type, TriangleType.Error);

            type = redPill.WhatShapeIsThis(0, 0, -1);
            Assert.AreEqual(type, TriangleType.Error);
        }

        [TestMethod]
        public void WhatShapeIsThisTest2()
        {
            MyRedPill redPill = new MyRedPill();
            TriangleType type = redPill.WhatShapeIsThis(2,2,1);
            Assert.AreEqual(type, TriangleType.Isosceles);
        }

        [TestMethod]
        public void WhatShapeIsThisTest3()
        {
            MyRedPill redPill = new MyRedPill();
            TriangleType type = redPill.WhatShapeIsThis(2, 2, 2);
            Assert.AreEqual(type, TriangleType.Equilateral);
        }

        [TestMethod]
        public void WhatShapeIsThisTest4()
        {
            MyRedPill redPill = new MyRedPill();
            TriangleType type = redPill.WhatShapeIsThis(1, 2, 3);
            Assert.AreEqual(type, TriangleType.Scalene);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void WhatShapeIsThisTest5()
        {
            MyRedPill redPill = new MyRedPill();
            TriangleType type = redPill.WhatShapeIsThis(2, 1, 3);
            Assert.AreEqual(type, TriangleType.Error);
        }

        [TestMethod]
        public void WhatShapeIsThisTest6()
        {
            MyRedPill redPill = new MyRedPill();
            TriangleType type = redPill.WhatShapeIsThis(3, 2, 1);
            Assert.AreEqual(type, TriangleType.Scalene);
        }

        [TestMethod]
        public void WhatShapeIsThisTest7()
        {
            MyRedPill redPill = new MyRedPill();
            TriangleType type = redPill.WhatShapeIsThis(12, 6, 14);
            Assert.AreEqual(type, TriangleType.Scalene);
        }

    }
}
