using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProj
{
    [TestClass]
    public class AshokMethodTest4
    {
        [TestMethod]
        public void TestMethod4()
        {
            string hello = WinFormsProj.AshokMethod4.GetString();
            Assert.AreEqual(hello, "Hello");
        }
    }
}
