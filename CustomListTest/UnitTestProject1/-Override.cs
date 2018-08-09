using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListTest;

namespace UnitTestProject1
{
    [TestClass]
    public class __Override
    {

        [TestMethod]
        public void TestSmallNumberList()
        {
            //Range
            CustomList<int> listOne = new CustomList<int> { 1, 2 };
            CustomList<int> listTwo = new CustomList<int> { 1, 5 };
            CustomList<int> combinedList = new CustomList<int>();

            //Act
            combinedList = (listOne - listTwo);
            int result = combinedList.count;
            int expected = 2;

            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}
