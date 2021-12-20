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
            Assert.AreEqual(5, Class228.FindGreatestCommonDivisor(0, 5));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(20, Class228.FindGreatestCommonDivisor(20, 0));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(10, Class228.FindGreatestCommonDivisor(40, 30));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(100, Class228.FindGreatestCommonDivisor(100, 400));
        }
    }
}
