using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> myList = new CustomList<int>();
            int myInt = 0;
            foreach(int hello in myList)
            {
                myInt += hello;
            }
        }
    }
}
