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
            CustomList<bool> customList = new CustomList<bool>();
            CustomList<bool> customList2 = new CustomList<bool>();
            customList.Add(true);
            customList.Add(true);
            customList2.Add(false);
            customList2.Add(false);
            customList2.Add(false);

            CustomList<bool> customList3 = customList.Zip(customList2);
            Console.ReadLine();
        }
    }
}
