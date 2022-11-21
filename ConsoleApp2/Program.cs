using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            const string pattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

            Console.WriteLine("Введите строку");

            string String = Console.ReadLine();

            string[] words = String.Split(' ');
            
            for (int i = 0; i < words.Length; i++)
                if (Regex.IsMatch(words[i],pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine(words[i]);
                }

            //var sortWord = words.Where(s => s.Contains("@gmail.com")); //var sortWords = from s in words where s.Contains("@gmail.com") select s;
            //foreach (var s in sortWord)
            //    sb.AppendLine(s);

            //Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
