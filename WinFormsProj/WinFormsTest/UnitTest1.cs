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
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            string testStr = WinFormsProj.Class1.Dummy;
            Assert.AreEqual(testStr, "Dummy");
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            string testStr = WinFormsProj.Class2.Test2;
            Assert.AreEqual(testStr, "Test2");
        }
    }
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod4()
        {
            string testStr = WinFormsProj.Class3.Test3;
            Assert.AreEqual(testStr, "Test3");
        }
    }
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod5()
        {
            string testStr = WinFormsProj.Class3.Test4;
            Assert.AreEqual(testStr, "Test4");
        }
    }
}
