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
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList.Add(14);
            customList.Add(14);
            customList.Add(4);
            customList.Add(14);
            customList.Add(14);
            customList.Add(100);
            customList2.Add(22);
            customList2.Add(22);
            customList2.Add(14);
            customList2.Add(4);
            customList2.Add(22);

            CustomList<int> actual = customList - customList2;
            Console.ReadLine();
        }
    }
}
