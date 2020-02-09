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
    public class IsHappyTaskTests
    {
        [TestMethod()]
        public void IsHappy()
        {
            var qq = new IsHappyTask().IsHappy(101);
            Assert.Fail();
        }
    }
}