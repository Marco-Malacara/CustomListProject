using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListTest;
namespace UnitTestProject1
{
    [TestClass]
    public class _Override
    {
        [TestMethod]
        public void TestSmallNumberList()
        {
            //Range
            CustomList<int> listOne = new CustomList<int> { 4, 2 };
            CustomList<int> listTwo = new CustomList<int> { 1, 5 };
            CustomList<int> combinedList = new CustomList<int>();

            //Act
            combinedList = (listOne + listTwo);
            int result = combinedList.count;
            int expected = 4;

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMediumNumberList()
        {
            //Range
            CustomList<int> listOne = new CustomList<int> { 4, 2, 5, 1, 6, 11, 223};
            CustomList<int> listTwo = new CustomList<int> { 1, 5, 8, 97, 14, 63, 12, 14};
            CustomList<int> combinedList = new CustomList<int>();

            //Act
            combinedList = (listOne + listTwo);
            int result = combinedList.count;
            int expected = 15;

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestSmallString()
        {
            //Range
            CustomList<string> listOne = new CustomList<string> { "hello", "World" };
            CustomList<string> listTwo = new CustomList<string> { "welcome" };
            CustomList<string> combinedList = new CustomList<string>();

            //Act
            combinedList = (listOne + listTwo);
            int result = combinedList.count;
            int expected = 3;

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMediumString()
        {
            //Range
            CustomList<string> listOne = new CustomList<string> { "hello", "World", "a", "b", "c", "d",};
            CustomList<string> listTwo = new CustomList<string> { "welcome", "z", "l", "m", "n", "o", "p" };
            CustomList<string> combinedList = new CustomList<string>();

            //Act
            combinedList = (listOne + listTwo);
            int result = combinedList.count;
            int expected = 13;

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void CheckIndexerIsCorrect()
        {
            //Range
            CustomList<string> listOne = new CustomList<string> { "hello", "World"};
            CustomList<string> listTwo = new CustomList<string> { "welcome" };
            CustomList<string> combinedList = new CustomList<string>();

            //Act
            combinedList = (listOne + listTwo);
            string result = combinedList[1];
            string expected = "World";

            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}
