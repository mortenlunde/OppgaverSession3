using Dumpify;

namespace OppgaverDelegater;

public static class Lambdas
{
    // PrintNumber
    public static void PrintNumberLamda(int num) => Console.WriteLine(num);

    // PrintMessage
    public static void PrintMessageLamda(string txt) => Console.WriteLine(txt);

    // PrintResult
    public static void PrintResultLambda(bool res) => Console.WriteLine(res);
    
    // rintData
    public static void PrintDataLambda (int num, string txt) => Console.WriteLine($"{txt} {num}.");

    // PrintNumbers
    public static void PrintNumbersLambda (int[] numbers) => numbers.Dump();

    // PrintMessages
    public static void PrintMessagesLambda (string[] msgs) => msgs.Dump(typeRenderingConfig: new TypeRenderingConfig {QuoteStringValues = false});
    
    // PrintResultMessage
    public static void PrintResultMessageLambda(bool result, string message) => Console.WriteLine(result ? $"Success: {message}" : $"Failed: {message}");
    
    // DoubleNumber
    public static int DoubleNumber(int num) => num * 2;
    
    // CountCharacter
    public static void CountCharacter(string txt) => Console.WriteLine($"Antall bokstaver i teksten: {txt.Count(char.IsLetter)}\n{txt}");
    
    // AddNumbers
    public static double AddNumbers(double num1, double num2) => num1 + num2;
    
    // SumNumbers
    public static int SumNumbers(IEnumerable<int> numbers, int sum = 0) => sum + numbers.Sum();

    public static string FormatData(int id, string name) => $"ID: {id}, Name: {name}";
}