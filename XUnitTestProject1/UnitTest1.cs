using ConsoleApp1;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Program.Main(new string[] { "--name", "bob" });
        }
    }
}