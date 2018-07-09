using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        public T[] curArray { get; set; }
        public int Count { get; set; }
        public object Current { get; }
        public T this[int i] { get {return curArray[i];} set {curArray[i] = value;}}
        public CustomList()
        {
            curArray = new T[0];
            Count = 0;
        }
        public void Add(T item)
        {
            if (Count == 0)
            {
                Count++;
                T[] newArray = new T[Count];
                newArray[Count - 1] = item;
                curArray = newArray;
            }
            else
            {
                Count++;
                T[] newArray = new T[Count];
                for (int i = 0; i < Count - 1; i++)
                {
                    newArray[i] = curArray[i];
                }

                newArray[Count - 1] = item;
                curArray = newArray;
            }
        }
        public bool Remove(T item)
        {
            for(int i = 0; i < Count; i++)
            {
                if(curArray[i].Equals(item))
                {
                    Count--;
                    this.Splice(i);
                    return true;
                }
            }
            return false;
        }
        private void Splice(int eleIdx)
        {
            if (Count == 0)
            {
                T[] newArray = new T[Count];
                for (int i = 0; i < Count + 1; i++)
                {
                    if (i != eleIdx)
                    {
                        newArray[i] = curArray[i];
                    }
                }
                curArray = newArray;
            }
            else if(eleIdx == 0 && Count == 2)
            {
                T[] newArray = new T[Count];
                for (int i = 0; i < Count + 1; i++)
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
                T[] newArray = new T[Count];
                for (int i = 0; i < Count + 1; i++)
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
            for(int i = 0; i < Count + customList2.Count; i++)
            {
                if(Count > i)
                {
                    customList3.Add(curArray[i]);
                }
                if(customList2.Count > i)
                {
                    customList3.Add(customList2.curArray[i]);
                }
            }
            return customList3;
        }
        public override string ToString()
        {
            // stringbuilder
            string myStr = "";
            for(int i = 0; i < Count; i++)
            {
                if(i == Count - 1)
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
            for(int i = 0; i < customList.Count; i++)
            {
                customList3.Add(customList.curArray[i]);
            }
            for(int i = 0; i < customList2.Count; i++)
            {
                customList3.Add(customList2.curArray[i]);
            }
            return customList3;
        }
        public static CustomList<T> operator -(CustomList<T> customList, CustomList<T> customList2)
        {
            for(int i = 0; i < customList.Count; i++)
            {
                for(int j = 0; j < customList2.Count; j++)
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
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < Count; i++)
            {
                yield return curArray[i];
            }
        }
    }
}