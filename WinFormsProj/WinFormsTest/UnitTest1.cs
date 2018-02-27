using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WinFormsTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            string testStr = WinFormsProj.Dummy.GetDummyString();
            Assert.AreEqual("dummy", testStr);
        }

        [TestMethod]
        public void TestMethodSum()
        {
            int x = 10, y = 15;
            Assert.AreEqual(x + y, WinFormsProj.DetriceClassSum.GetSum(x, y));
        }

        [TestMethod]
        public void TestMethodMultiply()
        {
            int x = 10, y = 15;
            Assert.AreEqual(x * y, WinFormsProj.DetriceClass2.Multiply(x, y));
        }

        [TestMethod]
        public void TestMethodSubtract()
        {
            int x = 10, y = 15;
            Assert.AreEqual(x - y, WinFormsProj.DetriceClass3.Subtract(x, y));
        }

        [TestMethod]
        public void TestMethodDivide()
        {
            int x = 10, y = 15;
            Assert.AreEqual(x / y, WinFormsProj.DetriceClass4.Divide(x, y));
        }
    }
}
