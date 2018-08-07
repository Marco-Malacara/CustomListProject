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
            CustomList<string> test = new CustomList<string>();
            test.Add("hello world");
            test.Add("bye world");
            Console.WriteLine(test[3]);
            Console.ReadLine();
        }
    }
}
