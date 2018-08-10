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
            CustomList<string> listOne = new CustomList<string> { "Marco", "Aly", "Trent", "Mike", "OtherMike" };
            CustomList<string> listTwo = new CustomList<string> { "Marco", "Aly", "Trenten", "Mike", "OtherMike" };
            CustomList<string> newList = new CustomList<string>();

            //Act
            newList = (listOne - listTwo);

            foreach (string item in newList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            }
    }
}
