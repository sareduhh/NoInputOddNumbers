using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_Input_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            for (counter = 1; counter <= 99; counter += 2)
            {
                System.Console.WriteLine(counter);
            }

        }
    }
}
