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
    public class MyPowTaskTests
    {
        [TestMethod()]
        public void MyPowTest()
        {
            var qq = new MyPowTask().MyPow(2, 10);
            Assert.AreEqual(1024, qq);
        }

        [TestMethod()]
        public void MyPowTest2()
        {
            var qq = new MyPowTask().MyPow(2, -2);
            Assert.AreEqual(0.25, qq);
        }

        [TestMethod()]
        public void MyPowTest3()
        {
            var qq = new MyPowTask().MyPow(2.1, 3);
            Assert.AreEqual(9.261, qq, 0.0000000001);
        }

        [TestMethod()]
        public void MyPowTest4()
        {
            var qq = new MyPowTask().MyPow(0.00001, 2147483647);
            Assert.AreEqual(0, qq);
        }

        [TestMethod()]
        public void MyPowTest5()
        {
            var qq = new MyPowTask().MyPow(1, 2147483647);
            Assert.AreEqual(1, qq);
        }

        [TestMethod()]
        public void MyPowTest6()
        {
            var qq = new MyPowTask().MyPow(2, -2147483648);
            Assert.AreEqual(0, qq);
        }

        [TestMethod()]
        public void MyPowTest7()
        {
            var qq = new MyPowTask().MyPow(-1, 2147483647);
            Assert.AreEqual(-1, qq);
        }

        [TestMethod()]
        public void MyPowTest8()
        {
            var qq = new MyPowTask().MyPow(0.44528, 0);
            Assert.AreEqual(1, qq);
        }

        [TestMethod()]
        public void MyPowTest9()
        {
            var qq = new MyPowTask().MyPow(-2, 2);
            Assert.AreEqual(4, qq);
        }

    }
}