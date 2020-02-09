using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject.Tests
{
    [TestClass()]
    public class OtherTaskTests
    {
        [TestMethod()]
        public void GetPageListTest()
        {
            var qq = new OtherTask().GetPageList(3, 2, 5);
            var qq2 = new OtherTask().GetPageList(7, 5, 5);
            var qq3 = new OtherTask().GetPageList(73, 66, 5);
            Assert.Fail();
        }

        [TestMethod()]
        public void isNumberTest()
        {
            var qq = new OtherTask().isNumber();
            Assert.Fail();
        }
    }
}