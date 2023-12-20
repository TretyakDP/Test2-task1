using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();
        List<int> numbers = Enumerable.Range(1, 8).Select(_ => random.Next(1, 100)).ToList();
        var sortedNumbers = numbers.OrderBy(x => x).ToList();
        int middleIndex = (int)Math.Ceiling(sortedNumbers.Count / 2.0);
        var secondHalf = sortedNumbers.Skip(middleIndex).ToList();
        var result = secondHalf.Select(x => x * x).OrderByDescending(x => x).ToList();
        Console.WriteLine("Исходная коллекция: " + string.Join(", ", numbers));
        Console.WriteLine("Отсортированная вторая половина, элементы в квадрате: " + string.Join(", ", result));
        Console.ReadLine();
    }
}