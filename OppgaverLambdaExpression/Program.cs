// Oppgave 1
Console.WriteLine(string.Join(", ", NumbersBiggerThanTen([1, 7, 99, 20, 11, 18, 5])));
static IEnumerable<int> NumbersBiggerThanTen(int[] numbers) => numbers.ToList().Where(num => num > 10);

// Oppgave 2