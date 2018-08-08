using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListTest;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for ArrayValueTest
    /// </summary>
    [TestClass]
    public class ArrayTempararyValueTest
    {

        [TestMethod]
        public void TestOneItem()
        {
            //Range
            CustomList<int> list = new CustomList<int> { 1 };
            list.ArrayValue();
            //Act
            int result = list.count;
            int expected = 1;
            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}
