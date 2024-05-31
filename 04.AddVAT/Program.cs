/*
1.38, 2.56, 4.4

1, 3, 5, 7

 */


Func<double, double> applyVat = x => x * 1.2;

double[] prices = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .Select(applyVat)
    .ToArray();

Console.WriteLine(string.Join(Environment.NewLine, prices.Select(x => x.ToString("f2"))));