/*
The following example shows how to use Function

Write a program that reads one line of text from console. Print count of words that start with Uppercase, after that print all those words in the same order like you find them in text.

 */

Predicate<string> checkCapitalized = word => char.IsUpper(word[0]);

Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Where(word => checkCapitalized(word))
    .ToList()));