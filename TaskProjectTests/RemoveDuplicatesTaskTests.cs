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
    public class RemoveDuplicatesTaskTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            var qq = new RemoveDuplicatesTask().RemoveDuplicates("abbaca");
            Assert.Fail();
        }
    }
}