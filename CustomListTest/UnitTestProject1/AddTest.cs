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
            Testing<int> list = new Testing<int>();
            int num = 12;
            //Act
            list.Add(num);
            int result = list.arr[0];
            int expected = list.arr[0];
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestAddMultipleNum()
        {
            //Range
            Testing<int> list = new Testing<int>();
            int num1 = 1;
            int num2 = 2;
            //Act
            int result = list.Add(num1, num2);
            int expected = list[1];
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestAddLargeAmount()
        {
            //Range
            Testing<int> list = new Testing<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;
            int num7 = 7;
            int num8 = 8;
            int num9 = 9;
            int num10 = 10;
            int num11 = 11;
            int num12 = 12;
            //Act
            int result = list.Add(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12);
            int expected = list[11];
            //Assert
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestUpTofiftyItems()
        {
            //Range
            Testing<int> list = new Testing<int>();
            for(int i = 0; i <=50; i++)
            {
                list.Add(i);
            }
            //Act
            int expected = 48;
            int result = list[47];
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestUpToHundredItems()
        {
            //Range
            Testing<int> list = new Testing<int>();
            for (int i = 0; i <= 100; i++)
            {
                list.Add(i);
            }
            //Act
            int expected = 98;
            int result = list[97];
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
