using ConsoleApp.Week3;


namespace ConsoleApp
{
    internal class SwitchFunctions
    {
        public static void FindPrime()
        {
            Console.WriteLine("Selected 1\n\tCheck if a Number is Prime or Not");
            Console.Write("Enter a number : ");
            string? input2 = Console.ReadLine();
            input2 = string.IsNullOrEmpty(input2) ? "0" : input2;
            int primeInput = Convert.ToInt32(input2);
            PrimeNumber P = new();
            P.Prime(primeInput);
        }

        public static void OddEven()
        {
            Console.WriteLine("Selected 2\n\tCheck if a number is Odd or Even");
            Console.Write("Enter a number : ");
            string? input3 = Console.ReadLine();
            input3 = string.IsNullOrEmpty(input3) ? "0" : input3;
            int OddEvenInput = Convert.ToInt32(input3);
            OddEven oe = new();
            oe.IsOdd(OddEvenInput);
        }

        public static void SwapVariables()
        {
            Console.WriteLine("Selected 3\n\tSwap the given two numbers");
            Console.Write("Enter number 1 : ");
            string? input4 = Console.ReadLine();
            input4 = string.IsNullOrEmpty(input4) ? "0" : input4;
            int a = Convert.ToInt32(input4);
            Console.Write("Enter number 2 : ");
            string? input5 = Console.ReadLine();
            input5 = string.IsNullOrEmpty(input5) ? "0" : input5;
            int b = Convert.ToInt32(input5);
            SwapNumbers S = new();
            S.Main(a, b);
        }

        public static void FindInArray()
        {
            Console.WriteLine("Selected 4\nSearch a term in an array");
            Console.Write("Enter to term to search : ");
            string? term = Console.ReadLine();
            term = string.IsNullOrEmpty(term) ? "Apple" : term;
            ArraySearch search = new();
            search.SearchTerm(term);

        }
    }
}
