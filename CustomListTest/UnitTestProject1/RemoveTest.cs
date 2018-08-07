using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListTest;


namespace UnitTestProject1
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void TestRemoveFromList()
        {
            Testing<int> list = new Testing<int>();
            list.Add(1, 2);
            list.Remove(2);
            int result = list.arr.Count();
            int expected = 1;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestRemoveMultiple()
        {
            Testing<int> list = new Testing<int>();
            list.Add(1, 2, 3, 4, 5);
            list.Remove(2, 3, 4);
            int result = list.arr.Count();
            int expected = 2;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestRemoveAt()
        {
            Testing<int> list = new Testing<int>();
            list.Add(1, 2, 3, 4, 5);
            list.Remove(3);
            int result = list.arr.Count();
            int expected = 4;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestRemoveFifty()
        {
            Testing<int> list = new Testing<int>();
            for (int i = 0; i <= 51; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i <= 50; i++)
            {
                list.Remove(i);
            }
            int result = list.Count();
            int expected = 1;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestRemoveHundred()
        {
            Testing<int> list = new Testing<int>();
            for (int i = 0; i <= 101; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i <= 100; i++)
            {
                list.Remove(i);
            }
            int result = list.arr.Count();
            int expected = 1;
            Assert.AreEqual(result, expected);
        }
    }
}
