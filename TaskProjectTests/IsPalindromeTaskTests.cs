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
    public class IsPalindromeTaskTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            Assert.AreEqual(true, new IsPalindromeTask().IsPalindrome(121));
        }

        [TestMethod()]
        public void IsPalindromeTest2()
        {
            Assert.AreEqual(false, new IsPalindromeTask().IsPalindrome(-121));
        }

        [TestMethod()]
        public void IsPalindromeTest3()
        {
            Assert.AreEqual(false, new IsPalindromeTask().IsPalindrome(10));
        }

        [TestMethod()]
        public void IsPalindromeTest4()
        {
            Assert.AreEqual(false, new IsPalindromeTask().IsPalindrome(1234));
        }

        [TestMethod()]
        public void IsPalindromeTest5()
        {
            Assert.AreEqual(true, new IsPalindromeTask().IsPalindrome(9889));
        }
    }
}