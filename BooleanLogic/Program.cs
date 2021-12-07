using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // ^ returns true if both are not equal. 
            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False
        }
    }
}
