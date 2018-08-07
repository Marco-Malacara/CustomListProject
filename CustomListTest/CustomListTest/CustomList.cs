using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTest
{

    public class CustomList<T> : IEnumerable<T>
    {
        protected T value;
        public T[] arr;
        public int count;
        public int capacity;

        public CustomList()
        {
            count = 0;
            capacity = 4;
        }

        public T this[int capacity]
        {
            get
            {
                if(capacity <= count)
                {
                    return arr[capacity];
                }
                else
                {
                    throw new System.ArgumentException("Chosen Index does not exist yet!");
                }
            }
            set { arr[capacity] = value; }
        }

        public void Add(T item)
        {
            arr = new T[capacity];
            count = GetCount();
            CheckIfIncreaseCapacity();
            arr[count - 1] = item;
            
        }

        public int GetCount()
        {
            int updatedCount = 0;
            for (int i = 0; i <= count; i++ )
            {
                if(i == updatedCount)
                {
                    updatedCount++;
                }
            }
            return updatedCount++;
        }

        public void CheckIfIncreaseCapacity()
        {
            if (capacity == count)
            {
               capacity = capacity * 2;
            }
        }
        
        ////////////////////////////////////////REMOVE METHOD START

        public bool Remove(T item)
        {
            if (count <= capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
