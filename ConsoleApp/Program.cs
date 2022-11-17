using ConsoleApp;

Console.WriteLine("\tSelect From the Numbers below:");
Console.Write("\t1. Prime");
Console.Write("\t2. OddEven");
Console.Write("\t3. Swap Numbers");
Console.Write("\t4. Array Search");
Console.WriteLine("\nEnter a number from above: ");


string? input1 = Console.ReadLine();
input1 = string.IsNullOrEmpty(input1) ? "0" : input1;
int inputInt = Convert.ToInt32(input1);

switch (inputInt)
{
    case 1:
        SwitchFunctions.FindPrime();
        break;
    case 2:
        SwitchFunctions.OddEven();
        break;
    case 3:
        SwitchFunctions.SwapVariables();
        break;
    case 4:
        SwitchFunctions.FindInArray();
        break;
    default:
        Console.WriteLine("No Value Entered");
        break;
}