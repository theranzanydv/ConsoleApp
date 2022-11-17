using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week3
{

    internal class SwapNumbers
    {
        public void Main(int Number1, int Number2)
        {
            Console.WriteLine("The Given Numbers are :\t\t [" + Number1 + "," + Number2 + "]");
            int temp = Number1;
            Number1 = Number2;
            Number2 = temp;
            Console.WriteLine("The Swapped Numbers are:\t [" + Number1 + "," + Number2 + "]");

        }
    }


}
