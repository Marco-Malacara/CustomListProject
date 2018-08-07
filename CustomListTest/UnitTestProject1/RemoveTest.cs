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
            CustomList<int> list = new CustomList<int>() { 5 };
            list.Remove(5);
            int result = list.count;
            int expected = 0;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestRemoveMultiple()
        {
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4, 5 };
            list.Remove(2);
            list.Remove(3);
            list.Remove(4);
            int result = list.count;
            int expected = 2;
            Assert.AreEqual(result, expected);
        }

        //[TestMethod]
        //public void TestRemoveAt()
        //{
        //    CustomList<int> list = new CustomList<int>();
        //    list.Add(1, 2, 3, 4, 5);
        //    list.Remove(3);
        //    int result = list.arr.Count();
        //    int expected = 4;
        //    Assert.AreEqual(result, expected);
        //}

        //[TestMethod]
        //public void TestRemoveFifty()
        //{
        //    CustomList<int> list = new CustomList<int>();
        //    for (int i = 0; i <= 51; i++)
        //    {
        //        list.Add(i);
        //    }
        //    for (int i = 0; i <= 50; i++)
        //    {
        //        list.Remove(i);
        //    }
        //    int result = list.Count();
        //    int expected = 1;
        //    Assert.AreEqual(result, expected);
        //}

        //[TestMethod]
        //public void TestRemoveHundred()
        //{
        //    CustomList<int> list = new CustomList<int>();
        //    for (int i = 0; i <= 101; i++)
        //    {
        //        list.Add(i);
        //    }
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        list.Remove(i);
        //    }
        //    int result = list.arr.Count();
        //    int expected = 1;
        //    Assert.AreEqual(result, expected);
        //}
    }
}
