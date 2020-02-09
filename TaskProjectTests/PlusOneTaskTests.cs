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
    public class PlusOneTaskTests
    {
        [TestMethod()]
        public void PlusOne()
        {
            var qq = new PlusOneTask().PlusOne(new int[] { 9, 9, 8 });
            Assert.Fail();
        }
    }
}