using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WinFormsTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            string testStr = WinFormsProj.Dummy.GetDummyString();
            Assert.AreEqual(testStr, "dummy");
        }
    }
}
