using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WinFormsTest
{
    [TestClass]
    public class JodiClass1Test
    {
        [TestMethod]

        public void JodiTest1()
        {
            int actual = WinFormsProj.JodiClass1.jodi(1, 2, 3);
            int expected = 1 + 2 + 3;
            Assert.AreEqual(expected, actual);
        }
    }
}
