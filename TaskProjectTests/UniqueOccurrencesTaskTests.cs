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
    public class UniqueOccurrencesTaskTests
    {
        [TestMethod()]
        public void UniqueOccurrencesTest()
        {
            //var list = new int[] { 1, 1, 1, 2, 2, 3 };
            //var list = new int[] {  1, 2 };
            //var list = new int[] { -3,0,1,-3,1,1,1,-3,10,0 };
            var list = new int[] { 3, 5, -2, -3, -6, -6 };

            var qq = new UniqueOccurrencesTask().UniqueOccurrences(list);

            Assert.Fail();
        }
    }
}