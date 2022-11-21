using ParseLib;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string exp = Console.ReadLine();

                Parse parse = new Parse(exp);

                Console.WriteLine(parse.CalculateExpression());
            }
        }
    }
}
