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
    public class ExcelSheetColumnNumberTaskTests
    {
        [TestMethod()]
        public void TitleToNumberTest()
        {
            var qq = new ExcelSheetColumnNumberTask().TitleToNumber("YZ");

            Assert.Fail();
        }
    }
}

namespace TaskProjectTests
{
    class ExcelSheetColumnNumberTaskTests
    {


    }
}
