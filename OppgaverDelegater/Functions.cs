using Dumpify;

namespace OppgaverDelegater;

public static class Functions
{
    // PrintNumber
    public static void PrintNumber(int num)
    {
        num.Dump();
    }
    
    // PrintMessage
    public static void PrintMessage(string txt)
    {
        txt.Dump(typeRenderingConfig: new TypeRenderingConfig {QuoteStringValues = false});
    }
    
    // PrintResult
    public static void PrintResult(bool res)
    {
        res.Dump();
    }
    
    // PrintDoubleFunc
    public static void PrintDoubleFunc(double number)
    {
        number.Dump();
    }
    
    // PrintData
    public static void PrintData(int num, string txt)
    {
        Console.WriteLine($"{txt} {num}.");
    }
    
    // PrintNumbers
    public static void PrintNumbers(int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("");
    }
    
    // PrintMessages
    public static void PrintMessages(string[] msgs)
    {
        foreach (string msg in msgs)
        {
            Console.Write(msg + " ");
        }
        Console.WriteLine("");
    }
    
    // PrintSum
    public static void PrintSum(int num1, int num2)
    {
        Console.WriteLine($"Sum: {num1+num2}");
    }
    
    // PrintResultMessage
    public static void PrintResultMessage(bool result, string message)
    {
        if (result)
        {
            Console.WriteLine("Success: " + message);
        }
        else
        {
            Console.WriteLine("Failed: " + message);
        }
    }
    
    // PrintSumOfThreeNumbers
    public static int PrintSumOfThreeNumbers(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
    
    // DoubleNumber
    public static int PrintDoubleNumber(int num)
    {
        return num * 2;
    }
    
    // CountCharacter
    public static void CountCharacter(string txt)
    {
        int chars = txt.Count(c => char.IsLetter(c));
        Console.WriteLine($"Antall bokstaver i teksten: {chars}\n{txt}");
    }
    
    // AddNumbers
    public static double AddNumbers(double num1, double num2)
    {
        return num1 + num2;
    }
    
    // NegateValue
    public static bool NegateValue(bool value)
    {
        return !value;
    }
    
    // SumNumbers
    public static int SumNumbers(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    
    //ConcentrateStrings
    public static string ConcentrateStrings(string[] strings)
    {
        string txt = string.Empty;
        foreach (string s in strings)
        {
            txt += s + " ";
        }

        return txt;
    }
    
    // MultiplyNumbers
    public static int MultiplyNumbers(int num1, int num2)
    {
        return num1 * num2;
    }
    
    // CombineStrings
    public static void CombineStrings(string str1, string str2)
    {
        (str1 + str2).Dump(typeRenderingConfig: new TypeRenderingConfig {QuoteStringValues = false});
    }
    
    // FormatData
    public static string FormatData(int id, string name)
    {
        return "ID: " + id + ", Name: " + name;
    }
    
    // IsGreaterThan
    public static bool IsGreaterThan(int num1, int num2)
    {
        return num1 > num2;
    }
}