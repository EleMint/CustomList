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
            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);

            CustomList<int> customList3 = customList.Zip(customList2);
            Console.ReadLine();
        }
    }
}
