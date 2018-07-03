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
        public int arrayCount;
        public T this[int i]
        {
            get { return curArray[i]; }
            set { curArray[i] = value; }
        }
        // Constructor
        public CustomList()
        {
            curArray = new T[0];
            arrayCount = 0;
        }
        // Member Methods
        public void Add(T item)
        {
            if (arrayCount == 0)
            {
                arrayCount++;
                T[] newArray = new T[arrayCount];
                newArray[arrayCount - 1] = item;
                curArray = newArray;
            }
            else
            {
                arrayCount++;
                T[] newArray = new T[arrayCount];
                for (int i = 0; i < arrayCount - 1; i++)
                {
                    newArray[i] = curArray[i];
                }

                newArray[arrayCount - 1] = item;
                curArray = newArray;
            }
        }
        public bool Remove(T item)
        {
            for(int i = 0; i < arrayCount; i++)
            {
                if(curArray[i].Equals(item))
                {
                    arrayCount--;
                    this.Splice(i);
                    return true;
                }
            }
            return false;
        }
        public void Splice(int eleIdx)
        {
            if (arrayCount == 0)
            {
                T[] newArray = new T[arrayCount];
                for (int i = 0; i < arrayCount + 1; i++)
                {
                    if (i != eleIdx)
                    {
                        newArray[i] = curArray[i];
                    }
                }
                curArray = newArray;
            }
            else if(eleIdx == 0 && arrayCount == 2)
            {
                T[] newArray = new T[arrayCount];
                for (int i = 0; i < arrayCount + 1; i++)
                {
                    if (i > eleIdx)
                    {
                        newArray[i - 1] = curArray[i];
                    }
                }
                curArray = newArray;
            }
            else
            {
                T[] newArray = new T[arrayCount];
                for (int i = 0; i < arrayCount + 1; i++)
                {
                    if(i < eleIdx)
                    {
                        newArray[i] = curArray[i];
                    }
                    else if(i > eleIdx)
                    {
                        newArray[i - 1] = curArray[i];
                    }
                }
                curArray = newArray;
            }
        }
        public CustomList<T> Zip(CustomList<T> customList2)
        {
            CustomList<T> customList3 = new CustomList<T>();
            for(int i = 0; i < this.arrayCount + customList2.arrayCount; i++)
            {
                if(customList2.arrayCount > i)
                {
                    customList3.Add(this.curArray[i]);
                }
                if(this.arrayCount > i)
                {
                    customList3.Add(customList2.curArray[i]);
                }
            }
            return customList3;
        }
    }
}
