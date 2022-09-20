using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Lab_2
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int Degree;

            Console.WriteLine("Введите степень полинрома");

            Degree = Convert.ToInt32(Console.ReadLine());

            double[] Coefs = new double[Degree];

            for (int i = 0; i < Coefs.Length; i++)
            {
                Coefs[i] = Convert.ToDouble(Console.ReadLine());
            }

            Polynom P = new Polynom(Coefs);

            Console.WriteLine("\tИсходный полином:");

            P.show();

            Console.WriteLine("\tПроизведение полиномов:");

            // Произведение полиномов (результат):
            P.prod(P).show();

            Console.ReadKey();
        }
    }
}
