using System;

namespace cSharpAdvanced_Delegates
{
    class Program
    {
        public delegate int IntFn(int i, int j);
        static void Main(string[] args)
        {
            int AddFn(int n, int m) => n + m;
            int SubFn(int n, int m) => n - m;

            IntFn fn = AddFn;
            var plus = fn(9, 5);  // 14
            Console.WriteLine(plus);

            fn = SubFn;
            var minus = fn(9, 5);  //4
            Console.WriteLine(minus);
            
        }
    }
}
