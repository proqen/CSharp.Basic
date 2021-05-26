using System;

namespace Task6._4
{
    static class Extension
    {
        public static void Sorting(this int [] array)
        {
            Array.Sort(array);
            foreach (var item in array)
                Console.WriteLine(item);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            var arrayInt = new int[] { 2, 3, 1, 4, 5, 2, 67, 12, 3 };
            arrayInt.Sorting();
        }
    }
}
