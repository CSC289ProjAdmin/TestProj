using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProj
{
    [TestClass]
    public class AshokMethodTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            decimal testDec = WinFormsProj.AshokMethod2.GetDecimal();
            Assert.AreEqual(testDec, 5.5M);
        }
    }
}
