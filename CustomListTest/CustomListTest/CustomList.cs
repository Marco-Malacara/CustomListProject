using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTest
{

    public class CustomList<T> : IEnumerable
    {
        protected T item;
        private int ignoreItem;
        public T[] arr;
        public int count;
        public int capacity;

        public CustomList()
        {
            
            count = 0;
            capacity = 4;
            arr = new T[capacity];
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                newList.Add(listOne[i]);
            }
            for (int i = 0; i < listTwo.count; i++)
            {
                newList.Add(listTwo[i]);
            }
            return newList;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                for (int j = 0; j < listTwo.count; j++)
                {
                    if (listOne[i].Equals(listTwo[j]))
                    {
                        listOne.Remove(listOne[i]);
                    }
                }
                newList.Add(listOne[i]);
            }
            return newList;
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
            for (int i = 0; i < count; i++ )
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
        
        public bool Remove(T item)
        {
            bool removedItem = false;
            

            if (count <= capacity)
            {
                for (int i = 0; i < count; i++)
                {
                    ignoreItem++;
                    if (arr[i].Equals(item))
                    {
                        removedItem = true;
                        arr[i] = arr[i + ignoreItem];
                        arr = ShiftArrayDown();
                    }
                }
                ignoreItem = 0;
                count--;
            }
            else
            { 
                
            }
            return removedItem;
        }

        public T[] ShiftArrayDown()
        {
            T[] shiftArray = new T[capacity];

            for (int i = 0; i < count; i++)
            {

                if(i == ignoreItem - 1 || i > ignoreItem - 1)
                {
                    shiftArray[i] = arr[i + 1];
                }
                

                else
                {
                    shiftArray[i] = arr[i];
                }
            }
            return shiftArray;
        }

        public void Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            int largestCount = listOne.count > listTwo.count ? listOne.count : listTwo.count;

            for (int i = 0; i < largestCount; i++)
            {
                if (i < listOne.count && i < listTwo.count)
                {
                    Add(listOne[i]);
                    Add(listTwo[i]);
                }
                else if (i > listOne.count)
                {
                    Add(listTwo[i]);
                }
                else if (i > listTwo.count)
                {
                    Add(listOne[i]);
                }
                else
                {
                    break;
                }
            }
        }


        public IEnumerator GetEnumerator()
        {
            {
                for (int i = 0; i < count; i++)
                {
                    yield return arr[i];
                }
                yield break;
            }
        }
    }
}
