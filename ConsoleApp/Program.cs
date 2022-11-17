
using ConsoleApp;

Console.WriteLine("\tSelect From the Numbers below:");
WriteLine.Cw("\t1. Prime");
WriteLine.Cw("\t2. OddEven");
WriteLine.Cw("\t3. Swap Numbers");
WriteLine.Cw("\t4. Array Search");
WriteLine.Cw("\nEnter a number from above: ");


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
