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
        public T[] arr = new T[10];
        public Testing()
        {
           
        }

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        public void Add(T index)
        {
            
        }
    }
}
