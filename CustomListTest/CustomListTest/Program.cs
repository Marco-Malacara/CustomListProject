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
            CustomList<int> listOne = new CustomList<int> { 1, 3, 4, 5, 7, 6 };
            CustomList<int> listTwo = new CustomList<int> { 1, 8, 9, 5, 7, 8 };
            CustomList<int> newList = new CustomList<int>();

            listOne.ToString();
            Console.WriteLine(listOne);
            Console.ReadLine();

            foreach (int item in newList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            }
    }
}
