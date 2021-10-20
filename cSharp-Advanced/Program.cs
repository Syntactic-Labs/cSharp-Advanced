using System;

namespace cSharp_Advanced
{
    record Student(int Id, string Firstname, string Lastname, int SAT);
    class Program
    {
        static void Main(string[] args)
        {
            var joe = new Student(1, "Joe", "Smith", 1000);
            Student jane = new(2, "Jane", "Doe", 1200);
            jane = jane with { SAT = 1250 };
            Console.WriteLine(jane);
            
        }
    }
}
