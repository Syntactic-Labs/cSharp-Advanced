using System;

namespace cSharp_Advanced
{
    record Student(int Id, string Firstname, string Lastname, int SAT, string Nickname);
    class Program
    {
        static void Main(string[] args)
        {
            var joe = new Student(1, "Joe", "Smith", 1000, "Jumpy Joe");
            Console.WriteLine($"joe before = {joe.Nickname}");
            Student jane = new(2, "Jane", "Doe", 1200, "Jittery Jane");
            jane = jane with { SAT = 1250 };
            joe = joe with { Nickname = "Jammin Joe" };
            Console.WriteLine($"joe after = {joe.Nickname}");
            Console.WriteLine($"{jane.Nickname} | {jane.SAT}");
            var t = jane.GetType();
            Console.WriteLine($"jane is of type = {t}");
            var p = typeof(System.String);
            Console.WriteLine(p);
            


        }
    }
}
