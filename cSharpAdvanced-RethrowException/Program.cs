using System;

namespace cSharpAdvanced_RethrowException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("Test Exception");
            }
            catch (Exception e)
            {
                var ex = e;
                throw;
            }
        }
    }
}
