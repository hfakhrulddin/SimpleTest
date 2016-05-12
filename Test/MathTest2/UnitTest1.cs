using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOp2;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;


namespace MathTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MathOperations obj = new MathOperations();
            int result = obj.add(10, 10);
            Assert.AreEqual(20, result);
        }
    }
}
