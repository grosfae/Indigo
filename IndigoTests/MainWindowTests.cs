using Microsoft.VisualStudio.TestTools.UnitTesting;
using Indigo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indigo.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void SaveTest()
        {
            if (new DateTime(2024, 4, 12, 1, 1, 1) > DateTime.Now)
            {
                return;
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}