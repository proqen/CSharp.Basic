using System;

namespace Task11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection carCollection = new();

            carCollection.Add(new Car { Name = "Mersedes", Year = 1996 });
            carCollection.Add(new Car { Name = "Honda", Year = 2002 });

            Console.WriteLine("Length = " + carCollection.Count());

            foreach (var item in carCollection)
            {
                Console.WriteLine(item.Name + " " + item.Year);
            }
        }
    }
}
