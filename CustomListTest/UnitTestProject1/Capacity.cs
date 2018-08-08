using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListTest;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for Capacity
    /// </summary>
    [TestClass]
    public class Capacity
    {
        
        [TestMethod]
        public void TestCapacityIncreasesOnce()
        {
            CustomList<int> list = new CustomList<int> { 1, 2, 3, 4 };

            int result = list.capacity;
            int expected = 8;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCapacityIncreaseWithString()
        {
            CustomList<string> list = new CustomList<string> { "hello", "world", "!", "!" };

            int result = list.capacity;
            int expected = 8;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCapacityIncreaseBy4()
        {
            CustomList<int> list = new CustomList<int>();
            for(int i = 0; i < 33; i++)
            {
                list.Add(i);
            }

            int result = list.capacity;
            int expected = 64;

            Assert.AreEqual(result, expected);
        }
    }
}
