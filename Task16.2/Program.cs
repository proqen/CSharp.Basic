using System;

namespace Task16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block = new Block { Id = 1, Name = "Kamchybek", Email = "email@email.com", City = "Bishkek" };
            Console.WriteLine(block.Equals(block));
            Console.WriteLine(block.ToString());
        }
    }
}
