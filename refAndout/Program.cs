using System;

namespace refAndout
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of why and when to use ref "reference"
            void plus1(int i){
                i++;
            }
            var b = 0;
            plus1(b);
            Console.WriteLine($"No ref b = {b}.");

            void add1 (ref int i){
                i++;
            }
            var a = 0;
            add1(ref a);
            Console.WriteLine($"ref a = {a}");
            Console.WriteLine("ref allows you to change the variable. without it you are changing a copy of the var.");

            //example of why and when to use out

            decimal pi = 0m;
            Console.WriteLine($"the value of pi before = {pi}");
            void getPi(out decimal val){
                val = 3.1415m;
            }
            getPi(out pi);
            Console.WriteLine($"the value of pi after = {pi}");

        }

    }
}
