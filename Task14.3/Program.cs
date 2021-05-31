using System;
using System.Collections.Generic;

namespace Task14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            MyDictionary<int, int> myDictionary = new();

            myDictionary.Add(1,2);
            myDictionary.Add(2,3);
            myDictionary.Add(3,4);

            foreach(var item in myDictionary)
            Console.WriteLine(item);
        }
    }
}
