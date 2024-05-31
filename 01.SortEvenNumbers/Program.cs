/*
4, 2, 1, 3, 5, 7, 1, 4, 2, 12

1, 3, 5

2, 4, 6

 */

Console.WriteLine(string.Join(", ",Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Where(numbers => numbers % 2 == 0)
    .OrderBy(numbers => numbers)
    ));
