using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        public T[] curArray { get; set; }
        public int arrayCount { get; set; }
        public T this[int i] { get {return curArray[i];} set {curArray[i] = value;}}
        public CustomList()
        {
            curArray = new T[0];
            arrayCount = 0;
        }
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
        private void Splice(int eleIdx)
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
            for(int i = 0; i < arrayCount + customList2.arrayCount; i++)
            {
                if(arrayCount > i)
                {
                    customList3.Add(curArray[i]);
                }
                if(customList2.arrayCount > i)
                {
                    customList3.Add(customList2.curArray[i]);
                }
            }
            return customList3;
        }
        public override string ToString()
        {
            string myStr = "";
            for(int i = 0; i < arrayCount; i++)
            {
                if(i == arrayCount - 1)
                {
                    myStr += $"{curArray[i]}";
                }
                else
                {
                    myStr += $"{curArray[i]}, ";
                }
                
            }
            return myStr;
        }
        public static CustomList<T> operator +(CustomList<T> customList, CustomList<T> customList2)
        {
            CustomList<T> customList3 = new CustomList<T>();
            for(int i = 0; i < customList.arrayCount; i++)
            {
                customList3.Add(customList.curArray[i]);
            }
            for(int i = 0; i < customList2.arrayCount; i++)
            {
                customList3.Add(customList2.curArray[i]);
            }
            return customList3;
        }
        public static CustomList<T> operator -(CustomList<T> customList, CustomList<T> customList2)
        {
            for(int i = 0; i < customList.arrayCount; i++)
            {
                for(int j = 0; j < customList2.arrayCount; j++)
                {
                    if(customList.curArray[i].Equals(customList2.curArray[j]))
                    {
                        customList.Remove(customList2.curArray[j]);
                        i--;
                        break;
                    }
                }
            }
            
            return customList;
        }
    }
}