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
            CustomList<int> test = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int item in test)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}
