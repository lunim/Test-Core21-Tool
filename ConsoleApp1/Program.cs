using System;
using System.CommandLine;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var addressee = "world";

            ArgumentSyntax.Parse(args, syntax =>
            {
                syntax.DefineOption("n|name", ref addressee, "The addressee to greet");
            });

            Console.WriteLine("Hello {0}!", addressee);
        }
    }
}
