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
            customList.Add(16);
            
            customList.Remove(16);
            customList.Remove(4);
            Console.ReadLine();
        }
    }
}
