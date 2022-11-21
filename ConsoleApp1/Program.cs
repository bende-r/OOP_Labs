using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину слова: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите строку");
            string String = Console.ReadLine();

            string[] words = String.Split(' ', ',', '.','!','&','?');

            var sortWords = from s in words where s.Length == n orderby s select s;
            foreach (var s in sortWords)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
