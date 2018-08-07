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
            Testing<int> list = new Testing<int>();
            list.Add(1);
            int result = list.arr.Count();
            int expected = 1;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCountMethodUpToFive()
        {
            Testing<int> list = new Testing<int>();
            for (int i = 0; i <= 5; i++)
            {
                list.Add(i);
            }
            int result = list.arr.Count();
            int expected = 5;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCountMethodUpToFifty()
        {
            Testing<int> list = new Testing<int>();
            for (int i = 0; i <= 50; i++)
            {
                list.Add(i);
            }
            int result = list.arr.Count();
            int expected = 50;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCountMethodUpToHundred()
        {
            Testing<int> list = new Testing<int>();
            for (int i = 0; i <= 100; i++)
            {
                list.Add(i);
            }
            int result = list.arr.Count();
            int expected = 100;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCountMethodUpToTwoHundred()
        {
            Testing<int> list = new Testing<int>();
            for (int i = 0; i <= 200; i++)
            {
                list.Add(i);
            }
            int result = list.arr.Count();
            int expected = 200;
            Assert.AreEqual(result, expected);
        }
    }
}
