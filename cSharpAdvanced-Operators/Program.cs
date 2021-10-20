using System;

namespace cSharpAdvanced_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var boolean = false;
            var nbr = 0;
            //boolean is false to && acts as a shortcut and leave the if statement aka there is no point to continue
            if (boolean && ++nbr > 10)
            {
            }
                Console.WriteLine(nbr);
        }
    }
}
