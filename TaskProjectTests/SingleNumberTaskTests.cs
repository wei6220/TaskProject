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
    public class SingleNumberTaskTests
    {
        [TestMethod()]
        public void SingleNumberTest()
        {
            //var qq = new SingleNumberTask().SingleNumber(new int[] { 2, 2, 1 });
            var qq = new SingleNumberTask().SingleNumber(new int[] { 4, 1,2, 1,2 });

            Assert.Fail();
        }
    }
}