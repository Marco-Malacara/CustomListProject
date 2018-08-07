using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTest
{
    public class Testing<T>
    {
        protected T value;
        private T[] arr;
        public int count;
        public int capacity;

        public Testing()
        {
            count = 1;
            capacity = 4;
            arr = new T[capacity];
        }

        public T this[int capacity]
        {
            get { return arr[capacity]; }
            set { arr[capacity] = value; }
        }

        public void Add(T item)
        {
            GetCount();
            arr[count - 1] = item;
            Console.WriteLine(item);
            Console.ReadLine();
        }

        public int GetCount()
        {
            int newCount;
            for (newCount = 0; newCount <= count;)
            {
                if(newCount == count)
                {
                    return count + 1;
                }
                else
                {
                    newCount++;
                }
            }
            return count;
        }
    }
}
