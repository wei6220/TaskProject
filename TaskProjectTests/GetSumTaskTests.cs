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
    public class GetSumTaskTests
    {
        [TestMethod()]
        public void GetSumTest()
        {
            var qq = new GetSumTask().GetSum(1, 3);
            Assert.Fail();
        }

        [TestMethod()]
        public void GetSum2Test()
        {
            var qq = new GetSumTask().GetSum2(7, 3);
            Assert.Fail();
        }
    }
}