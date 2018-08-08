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
        protected T item;
        public T[] arr;
        public int count;
        public int capacity;

        public CustomList()
        {
            
            count = 0;
            capacity = 4;
            arr = new T[capacity];
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
            count = GetCount();
            CheckIfIncreaseCapacity();
            arr[count - 1] = item;
            arr = ArrayValue();
        }

        public T[] ArrayValue()
        {
            T[] value = new T[capacity];
            for(int i = 0; i < count; i++)
            {
                value[i] = arr[i];
            }
            return value;
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
            bool removedItem = false;

            if (count <= capacity)
            {
                for (int i = 0; i < count; i++)
                {
                    
                    int ignoreItem = 0;
                    if (arr[i].Equals(item))
                    {
                        ignoreItem++;
                        removedItem = true;
                        arr[i] = arr[i - ignoreItem];
                    }

                    if (removedItem == true)
                    {
                        count = CountDown();
                    }
                }
            }
            else
            {
                
            }
            return removedItem;
        }

        public int CountDown()
        {
            int countDown = 0;
            for (int i = 0; i <= count; i++)
            {
                if (i == countDown)
                {
                    countDown--;
                }
            }
            return countDown--;
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
