using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Polynom
    {
        private int n;          
        private double[] a;

        
        void set(double[] a)
        {
            this.n = a.Length;
            this.a = new double[n];
            int i;
            for (i = 0; i < n; i++)
                this.a[i] = a[i];
        }

        void set(int n, double z)
        {
            this.n = n;
            this.a = new double[n];
            int i;
            for (i = 0; i < n; i++)
                this.a[i] = z;
        }

        void set(int n)
        {
            set(n, 0);
        }

        // Отображение коэффициентов полинома:
        public void show()
        {
            for (int i = 0, j = n; i < n && j > 0; i++, j--)
            {
                if (j == 1)
                    Console.Write($" x * {a[i]}");
                else if (a[i] == 0)
                    Console.Write("");
                else
                    Console.Write($" x^{j} *{a[i]} +");
            }
        }

        // Произведение полинома на число:
        public Polynom prod(double z)
        {
            Polynom t = new Polynom(a);
            for (int i = 0; i < n; i++)
                a[i] *= z;
            return t;
        }

        // Произведение полинома на полином:
        public Polynom prod(Polynom Q)
        {
            int N = n + Q.n;
            Polynom t = new Polynom(N);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < Q.n; j++)
                {
                    t.a[i + j] += a[i] * Q.a[j];
                }
            }
            return t;
        }

        // Конструкторы класса:

        public Polynom(double[] a)
        {
            set(a);
        }

        public Polynom(int n)
        {
            set(n);
        }
    }
}

