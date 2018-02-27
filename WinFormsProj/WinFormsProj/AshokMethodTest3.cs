using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProj
{
    [TestClass]
    public class AshokMethodTest3
    {
        [TestMethod]
        public void Method3()
        {
            string lastname = WinFormsProj.AshokMethod3.GetLastN();
            Assert.AreEqual(lastname, "Thakur");
        }
    }
}
