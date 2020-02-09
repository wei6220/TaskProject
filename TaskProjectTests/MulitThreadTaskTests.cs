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
    public class MulitThreadTaskTests
    {
        [TestMethod()]
        public void ThreadTestTest()
        {
            new MulitThreadTask().ThreadTest();
            Assert.Fail();
        }
    }
}