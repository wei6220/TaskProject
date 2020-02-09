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
    public class SubtractProductAndSumTaskTests
    {
        [TestMethod()]
        public void SubtractProductAndSumTest()
        {
            var qq = new SubtractProductAndSumTask().SubtractProductAndSum(234);
            Assert.AreEqual(15, qq);
        }

        [TestMethod()]
        public void SubtractProductAndSumTest2()
        {
            var qq = new SubtractProductAndSumTask().SubtractProductAndSum(4421);
            Assert.AreEqual(21, qq);
        }
    }
}