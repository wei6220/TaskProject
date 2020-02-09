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
    public class HammingWeightTaskTests
    {

        [TestMethod()]
        public void HammingWeightTest()
        {
            var qq = new HammingWeightTask().HammingWeight(11);
            Assert.Fail();
        }

    }
}