using System;
using System.Collections.Generic;

namespace Task10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            Console.WriteLine(myList.Count);

            foreach(var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
