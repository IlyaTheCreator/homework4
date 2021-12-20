using ClassLibrary228;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject228
{
    [TestClass]
    public class UnitTest228
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, Class228.FindGreatestCommonDivisor(0, 0));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, Class228.FindGreatestCommonDivisor(2, 4));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, Class228.FindGreatestCommonDivisor(13, 27));
        }
    }
}
