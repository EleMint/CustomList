using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        // Member Variables
        public T[] curArray;
        public T this[int i]
        {
            get { return curArray[i]; }
            set { curArray[i] = value; }
        }
        // Constructor
        public CustomList()
        {
            curArray = new T[0];
        }
        // Member Methods
        public void Add(T item)
        {
            T[] newArray = new T[curArray.Length + 1];
            newArray[newArray.Length - 1] = item;
            curArray = newArray;
        }
    }
}
