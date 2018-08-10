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
        public void TestNumberList()
        {
            //Range
            CustomList<int> listOne = new CustomList<int> { 1, 3, 4, 5, 7, 6 };
            CustomList<int> listTwo = new CustomList<int> { 1, 3, 4, 5, 7, 8 };
            CustomList<int> newList = new CustomList<int>();

            //Act
            newList = (listOne - listTwo);
            int result = newList.count;
            int expected = 1;

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestNumberListOutOfOrder()
        {
            //Range
            CustomList<int> listOne = new CustomList<int> { 1, 3, 4, 5, 7, 6 };
            CustomList<int> listTwo = new CustomList<int> { 1, 8, 9, 5, 7, 8 };
            CustomList<int> newList = new CustomList<int>();

            //Act
            newList = (listOne - listTwo);
            int result = newList.count;
            int expected = 3;

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestStringList()
        {
            //Range
            CustomList<string> listOne = new CustomList<string> { "Marco", "Aly", "Trent", "Mike", "OtherMike" };
            CustomList<string> listTwo = new CustomList<string> { "Marco", "Aly", "Trenten", "Mike", "OtherMike" };
            CustomList<string> newList = new CustomList<string>();

            //Act
            newList = (listOne - listTwo);
            int result = newList.count;
            int expected = 1;

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestStringListOutOfOrder()
        {
            //Range
            CustomList<string> listOne = new CustomList<string> { "Aly", "Mike", "Marco", "Trent", "OtherMike" };
            CustomList<string> listTwo = new CustomList<string> { "Marco", "Aly", "Trenten", "Mike", "OtherMike" };
            CustomList<string> newList = new CustomList<string>();

            //Act
            newList = (listOne - listTwo);
            int result = newList.count;
            int expected = 1;

            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}
