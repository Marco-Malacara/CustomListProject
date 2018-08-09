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
            CustomList<int> here = new CustomList<int>();
            CustomList<int> test = new CustomList<int>() { 1, 2, 3, 4, 5, };
            CustomList<int> testTwo = new CustomList<int> { 5, 2, 7, 4, 6 };

            here = (test - testTwo);


            foreach (int say in here)
            {
                Console.WriteLine(say);
            }
            Console.ReadLine();
        }
    }
}
