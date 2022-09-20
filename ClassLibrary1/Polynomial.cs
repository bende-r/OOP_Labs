using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Polynomial
    {
        private int n;
        private double[] k;

        public Polynomial(int N, double[] K)
        {
            n = N;
            k = K;
        } 

        public void PolinomView()
        {
            for (int i = 0, j = n; i < n && j>0; i++,j--)
            {
                if (k[i] == 0)
                    Console.Write($"x^{j}");
                else if (j == 1)
                    Console.Write($"x * {k[i]}");
                Console.Write($" x^{j} *{k[i]}+") ;
            }
        }
    }
}
