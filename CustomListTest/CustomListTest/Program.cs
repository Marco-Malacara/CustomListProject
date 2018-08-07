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
            CustomList<int> test = new CustomList<int>() { 1, 2, 3, 4 };
            test.Remove(2);
            test.Remove(3);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[0]);
            Console.ReadLine();
        }
    }
}
