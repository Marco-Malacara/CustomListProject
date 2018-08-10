using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create CustomList<T> listOne to hold items to get checked.
            CustomList<int> listOne = new CustomList<int> { 1, 3, 4, 5 };

            //Create CustomList<T> listTwo to hold items that will check listOne for same items.
            CustomList<int> listTwo = new CustomList<int> { 1, 8, 9, 5 };

            //Create CustomList<T> newList to hold the returned value of listOne - listTwo. Returned values will be { 3, 4 };
            CustomList<int> newList = new CustomList<int>();

            //Declare equation to remove recurring items from listOne.
            newList = (listOne - listTwo);

            //Write newList to console.
            foreach (int item in newList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            }
    }
}
