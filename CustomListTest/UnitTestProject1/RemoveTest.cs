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
            Testing<int> list = new Testing<int>() { 1, 2 };
            list.Remove(2);
            int result = list.arr[0]
            int expected = list[0];
            Assert.AreEqual(result, expected);
        }
    }
}
