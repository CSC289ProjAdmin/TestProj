using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProj
{
    [TestClass]
    public class AshokMethodTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string test = WinFormsProj.AshokMethod1.GetName();
            Assert.AreEqual(test, "Ashok");
        }
    }
}
