using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListTest;

namespace UnitTestProject1
{
    [TestClass]
    public class CountTest
    {
        [TestMethod]
        public void TestCountMethod()
        {
            CustomList<int> list = new CustomList<int>() { 3 };
            list.Add(1);
            int result = list.count;
            int expected = 2;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCountMethodUpToFive()
        {
            CustomList<int> list = new CustomList<int>() { 5, 6, 7, 2, 8 };
            int result = list.count;
            int expected = 5;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCountMethodUpToFifty()
        {
            CustomList<int> list = new CustomList<int>();
            for (int i = 0; i < 50; i++)
            {
                list.Add(i);
            }
            int result = list.count;
            int expected = 50;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCountMethodUpToHundred()
        {
            CustomList<int> list = new CustomList<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            int result = list.count;
            int expected = 100;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCountMethodUpToTwoHundred()
        {
            CustomList<int> list = new CustomList<int>();
            for (int i = 0; i < 200; i++)
            {
                list.Add(i);
            }
            int result = list.count;
            int expected = 200;
            Assert.AreEqual(result, expected);
        }
    }
}
