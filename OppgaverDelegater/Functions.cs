using Dumpify;

namespace OppgaverDelegater;

public class Functions
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
    }
    
    // PrintMessages
    public static void PrintMessages(string[] msgs)
    {
        foreach (string msg in msgs)
        {
            Console.Write(msg + " ");
        }
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
    public static int DoubleNumber(int num)
    {
        return num * 2;
    }
}