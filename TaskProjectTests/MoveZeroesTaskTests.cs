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
    public class MoveZeroesTaskTests
    {
        [TestMethod()]
        public void MoveZeroesTest()
        {
            int[] nums = { 0, 12, 0, 1, 3 };
            var qq = new MoveZeroesTask().MoveZeroes(nums);
            Assert.Fail();
        }
    }
}