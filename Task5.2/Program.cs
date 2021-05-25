using System;
using System.Linq;

var array = new int[10];

for (var i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);

Console.WriteLine(array.Max());
Console.WriteLine(array.Min());
Console.WriteLine(array.Sum());
Console.WriteLine(array.Average());
Console.WriteLine(String.Join(" ",array.Where(x => (x & 1) != 0)));