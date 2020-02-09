using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;
namespace TaskProject.Tests
{
    [TestClass()]
    public class ThreeSumTaskTests
    {
        [TestMethod]
        public void test_empty()
        {
            int[] nums = new int[] { };
            IList<IList<int>> expected = new List<IList<int>>();
            // Act
            IList<IList<int>> actual = new ThreeSumTask().ThreeSum(nums);


            // Assert
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i].ToList(), actual[i].ToList());
            }
        }

        [TestMethod]
        public void test_zero()
        {
            int[] nums = new int[] { 0, 0,0 };
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>(){ 0,0,0 }
            };
            // Act
            IList<IList<int>> actual = new ThreeSumTask().ThreeSum(nums);


            // Assert
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i].ToList(), actual[i].ToList());
            }
        }

        [TestMethod]
        public void test_1_0_m1()
        {
            // Arrange
            int[] nums = new int[] { 1, 0, -1 };
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>(){ -1,-0,1 }
            };
            // Act
            IList<IList<int>> actual = new ThreeSumTask().ThreeSum(nums);


            // Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }
        [TestMethod]
        public void test_m2_m1_0_3()
        {   
            // Arrange
            int[] nums = new int[] { -2, -1, 0, 3 };
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>(){ -2,-1,3 }
            };
            // Act
            IList<IList<int>> actual = new ThreeSumTask().ThreeSum(nums);


            // Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }
        [TestMethod]
        public void test_m1_m2_0_3()
        {
            // Arrange
            int[] nums = new int[] { -1, -2, 0, 3 , 1,-1 };
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>(){ -2,-1,3 },
                new List<int>(){ -1,0,1 }
            };
            // Act
            IList<IList<int>> actual = new ThreeSumTask().ThreeSum(nums);

            // Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }


        [TestMethod()]
        public void test_default_case()
        {
            // Arrange
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>(){ -1,-1,2},
                new List<int>(){-1,0,1 }
            };
            // Act
            IList<IList<int>> actual = new ThreeSumTask().ThreeSum(nums);

            // Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }
    }
}