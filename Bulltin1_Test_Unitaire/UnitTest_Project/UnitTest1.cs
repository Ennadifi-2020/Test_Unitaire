using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_Project
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]

        public void TestMethod1()
  
        {
            var expected = 8;
            var actual = calculator.calculator.Add(4, 4);
            Assert.AreEqual(expected, actual);

        }
    }
}
