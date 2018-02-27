using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest
{
    [TestClass]
    public class AshokNewClassTest
    {
        [TestMethod]
        public void Method2()
        {
            string test = WinFormsProj.AshokNewClass.GetString();
            Assert.AreEqual(test, "Ashok");
        }
    }
}
