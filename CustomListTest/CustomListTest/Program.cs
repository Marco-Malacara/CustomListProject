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
            CustomList<int> test = new CustomList<int>();
            test.Add(5);
            test.Add(1);
            test.Add(6);
            test.Add(2);
            test.Add(5);
            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.ReadLine();
        }
    }
}
