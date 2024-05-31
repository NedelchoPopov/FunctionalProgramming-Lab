/*
4, 2, 1, 3, 5, 7, 1, 4, 2, 12

2, 4, 6
 */


Func<string, int> parse = s => int.Parse(s);

List<int> numbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(parse)
    .ToList();

CountAndSum(numbers);

void CountAndSum(List<int> numbers)
{
    Console.WriteLine(numbers.Count + Environment.NewLine + numbers.Sum(n => n));

}