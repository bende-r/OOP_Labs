using ArrayLib;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] doubles = { 123, 50, 22, 21 };

            ArrayFloat A = new ArrayFloat(doubles);
            ArrayFloat B = new ArrayFloat(4);
            ArrayFloat C = new ArrayFloat();

            B.ChangeArray();
            C.WriteNewArray();

            A.ShowArray();
            B.ShowArray();
            C.ShowArray();

            double multipl_1 = A.GetMultiplicationOfElements((double)2);
            double multipl_2 = C.GetMultiplicationOfElements((double)2);
            double multipl_3 = B.GetMultiplicationOfElements((double)3);

            Console.WriteLine(multipl_1);
            Console.WriteLine(multipl_2);
            Console.WriteLine(multipl_3);

            double[] CMinusA = ArrayFloat.SubstractionOfArrays(C, A);
            double[] AMinusC = ArrayFloat.SubstractionOfArrays(A, C);
            double[] AMinusB = ArrayFloat.SubstractionOfArrays(A, B);
            double[] res = ArrayFloat.SubstractionOfArrays(AMinusB, C);

            foreach (double v in res)
                Console.WriteLine(v);

            foreach (double v in AMinusC)
                Console.WriteLine(v);

            foreach (double v in CMinusA)
                Console.WriteLine(v);

            bool introd = ArrayFloat.IntroductionOfArrays(A, B);

            if (!introd)
            {
                int ind = B.LengthOfArray() / 2 + 1;
                double multipl = B.GetMultiplicationOfElements(ind);
                int k = 0;


                for (int i = 0; i < A.LengthOfArray(); i++) if (A.GetElementByIndex(i) > multipl) k++;

                double[] newarr = new double[k];

                for (int i = 0; i < A.LengthOfArray(); i++)
                    if (A.GetElementByIndex(i) > multipl)
                        newarr[i] = A.GetElementByIndex(i);

                ArrayFloat arrayFloat = new ArrayFloat(newarr);

                arrayFloat.ShowArray();
            }

            Console.ReadKey();
        }
    }
}
