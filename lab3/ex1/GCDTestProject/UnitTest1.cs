using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GreatestCommonDivisor;

namespace GCDTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindGCDEuclidTest()
        {
            int a = 2806; // TODO: Initialize to an appropriate value
            int b = 345; // TODO: Initialize to an appropriate value
            int expected = 23; // TODO: Initialize to an appropriate value
            int actual;
            actual = GCDAlgorithms.FindGCDEuclid(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
