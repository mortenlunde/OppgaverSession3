using Dumpify;
using OppgaverDelegater;

Console.WriteLine("Funksjoner:");
Functions.PrintNumber(5);
Functions.PrintMessage("Hello Word");
Functions.PrintResult(true);
Functions.PrintDoubleFunc(2.0);
Functions.PrintData(7, "Lucky number");
Functions.PrintNumbers([1, 3, 7, 9, 15]);
Functions.PrintMessages(["Dette er", "et sett", "med stringer."]);
Functions.PrintSum(7, 10);
Functions.PrintResultMessage(true, "Trying to send message.");
Functions.PrintSumOfThreeNumbers(2, 5, 88).Dump();
Functions.DoubleNumber(5).Dump();

Console.WriteLine("\nLambda Uttrykk:");
Lambdas.PrintNumberLamda(55);
Lambdas.PrintMessageLamda("Hello Lamda-World!");
Lambdas.PrintResultLambda(false);
Action<double> printDouble = (number) => Console.WriteLine(number);
printDouble(1.5);
Lambdas.PrintDataLambda(5, "Ditt nøye utvalgte tall er");
Lambdas.PrintNumbersLambda([1,3, 5, 7, 9]);
Lambdas.PrintMessagesLambda(["Dette er", "en array", "med stringer."]);
Action<int, int> printSum = (num1, num2) => { int sum = num1 + num2; Console.WriteLine("Sum: " + sum); };
printSum(3, 7);
Lambdas.PrintResultMessageLambda(false, "Trying to send message.");
Action<int, int, int> printSumOfThreeNumbers = (num1, num2, num3) => Console.WriteLine($"Sum av de 3 tall: {num1+num2+num3}");
printSumOfThreeNumbers(1, 3, 14);
Lambdas.DoubleNumber(7).Dump();
//test