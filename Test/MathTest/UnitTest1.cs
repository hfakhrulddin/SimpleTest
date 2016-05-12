using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOp;


namespace MathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            MathOperations obj = new MathOperations();
            int result = obj.TestAdd(10, 10);
            Assret.AreEqual(20, result);
        }
    }
}
