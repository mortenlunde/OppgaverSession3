// Oppgave 1
Console.WriteLine(string.Join(", ", NumbersBiggerThanTen([1, 7, 99, 20, 11, 18, 5])));
static IEnumerable<int> NumbersBiggerThanTen(int[] numbers) => numbers.ToList().Where(num => num > 10);

// Oppgave 2
Console.WriteLine(string.Join(", ", StringsLongerThan5Chars(["Kort streng", "litt lengre streng", "kort", "gult kort"])));
static IEnumerable<string> StringsLongerThan5Chars(string[] strings) => strings.Where(str => str.Length > 5);

// Oppgave 3
Console.WriteLine((string.Join(", ", EvenNumbers([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]))));
static IEnumerable<int> EvenNumbers(int[] numbers) => numbers.ToList().Where(num =>num%2==0);

// Oppgave 4
Console.WriteLine(string.Join(", ", StringsThatStartsWitkLetterK(["Kort streng", "litt lengre streng", "kort", "gult kort"])));
static IEnumerable<string> StringsThatStartsWitkLetterK(string[] strings) => strings.Where(str => str[0].ToString().Equals("k", StringComparison.CurrentCultureIgnoreCase));

// Oppgave 5
Console.WriteLine(string.Join(", ", SumOfNumbersBiggerThanTen([1, 7, 99, 20, 11, 18, 5])));
static int SumOfNumbersBiggerThanTen(int[] numbers) => numbers.Where(num => num > 10).Sum();

// Oppgave 6
Console.WriteLine((string.Join(", ", EvenNumbersBiggerThanTen([1, 7, 99, 20, 11, 18, 5]))));
static IEnumerable<int> EvenNumbersBiggerThanTen(int[] numbers) => numbers.ToList().Where(num =>num%2==0 && num > 10);

// Oppgave 7
Console.WriteLine((string.Join(", ", AverageIntLessThanHundred([1, 7, 99, 20, 11, 18, 5, 120, 200]))));
static double AverageIntLessThanHundred(int[] numbers) => numbers.Where(num => num < 100).Average();

// Oppgave 8
Func<int[], bool> trueIfNegativeNum = (numbers) => numbers.Any(num => num < 0);
Console.WriteLine(trueIfNegativeNum([0, 1, 2, 3, -5]));
Console.WriteLine(trueIfNegativeNum([0, 1, 2, 3, 5]));

// Oppgave 9
Func<string[], bool> trueIfStringContainsWordCSharp = (strings) => strings.Contains("C#");
Console.WriteLine(trueIfStringContainsWordCSharp(["C", "Java", "Blaze", "Flash", "Python"]));
Console.WriteLine(trueIfStringContainsWordCSharp(["C#", "Java", "Blaze", "SilverLight", "Python"]));

// Oppgave 10
Console.WriteLine(string.Join(", ", SortNumbers([1, 7, 99, 20, 11, 18, 5])));
static IEnumerable<int> SortNumbers(int[] numbers) => numbers.OrderBy(num => num);

// Oppgave 11
Action<string[]> stringEndsWithE = (strings) => Console.WriteLine(string.Join(", ", strings.Where(str => str.EndsWith('e'))));
stringEndsWithE(["C", "Java", "Blaze", "Flash", "Python"]);