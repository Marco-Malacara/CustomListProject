using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListTest;

namespace UnitTestProject1
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void TestAddIntToEmptyList()
        {
            //Range
            CustomList<int> list = new CustomList<int>();
            int num = 12;
            //Act
            list.Add(num);
            int result = list.count;
            int expected = 1;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestUpToTwoItems()
        {
            //Range
            CustomList<int> list = new CustomList<int>();
            for (int i = 0; i < 2; i++)
            {
                list.Add(i);
            }
            //Act
            int expected = 2;
            int result = list.count;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestUpToTwelveItems()
        {
            //Range
            CustomList<int> list = new CustomList<int>();
            for (int i = 0; i < 12; i++)
            {
                list.Add(i);
            }
            //Act
            int expected = 12;
            int result = list.count;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestUpTofiftyItems()
        {
            //Range
            CustomList<int> list = new CustomList<int>();
            for (int i = 0; i < 50; i++)
            {
                list.Add(i);
            }
            //Act
            int expected = 50;
            int result = list.count;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestUpToHundredItems()
        {
            //Range
            CustomList<int> list = new CustomList<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            //Act
            int expected = 100;
            int result = list.count;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
