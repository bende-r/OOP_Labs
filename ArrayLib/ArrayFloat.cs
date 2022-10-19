using System;

namespace ArrayLib
{
    public class ArrayFloat
    {
        private double[] _doubles;
        private int _num;

        public ArrayFloat(int num)
        {
            _num = num;
            _doubles = new double[num];
        }
        public ArrayFloat(double[] doubles)
        {
            _doubles = doubles;
        }

        public ArrayFloat() { }

        public void ShowArray()
        {
            Console.WriteLine("Массив:");
            foreach (var item in _doubles)
                Console.WriteLine(item);
        }

        public void WriteNewArray()
        {
            Console.WriteLine("Введите число элементов");
            _num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы массива:");
            _doubles = new double[_num];
            for (int i = 0; i < _num; i++)
                _doubles[i] = Convert.ToDouble(Console.ReadLine());
        }

        public void ChangeArray()
        {
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < _num; i++)
                _doubles[i] = Convert.ToDouble(Console.ReadLine());
        }

        public int LengthOfArray()
        {
            return _doubles.Length;
        }

        public double GetElementByIndex(int index)
        {
            return _doubles[index];
        }

        public double GetMultiplicationOfElements()
        {
            double multiplication = 1;
            for (int i = 0; i < _doubles.Length; i++) multiplication *= _doubles[i];
            return multiplication;
        }

        public double Multiplication(ArrayFloat arrayFloat)
        {
            double multiplication = 1;
            for (int i = 0; i < _doubles.Length; i++) multiplication *= _doubles[i];
            return multiplication;
        }

        public double GetMultiplicationOfElements(double number)
        {
            double multiplication = 1;
            for (int i = 0; i < _doubles.Length; i++)
                if (i % number == 0)
                    multiplication *= _doubles[i];
            return multiplication;
        }

        public double GetMultiplicationOfElements(int index)
        {
            double multiplication = 1;

            for (int i = 0; i < index; i++) multiplication *= _doubles[i];

            return multiplication;
        }

        public double[] SubstractionOfArrays(double[] SecondArray)
        {
            int length1 = _doubles.Length;
            int length2 = SecondArray.Length;
            int maxlength = 0, i;
            if (length1 >= length2 && length1 != 0)
                maxlength = length1;
            else
            {
                if (length2 >= length1 && length2 != 0)
                    maxlength = length2;
            }
            double[] result = new double[maxlength];
            if (_doubles.Length >= SecondArray.Length)
            {
                for (i = 0; i < SecondArray.Length; i++) result[i] = _doubles[i] - SecondArray[i];
                for (; i < _doubles.Length; i++) result[i] = _doubles[i];
            }
            if (_doubles.Length <= SecondArray.Length)
            {
                for (i = 0; i < _doubles.Length; i++) result[i] = SecondArray[i] - _doubles[i];
                for (; i < SecondArray.Length; i++) result[i] = (-1) * SecondArray[i];
            }

            return result;
        }

        public static double[] SubstractionOfArrays(double[] SecondArray, ArrayFloat array_1)
        {
            int length1 = array_1._doubles.Length;
            int length2 = SecondArray.Length;
            int maxlength = 0, i;
            if (length1 >= length2 && length1 != 0)
                maxlength = length1;
            else
            {
                if (length2 >= length1 && length2 != 0)
                    maxlength = length2;
            }
            double[] result = new double[maxlength];
            if (array_1._doubles.Length >= SecondArray.Length)
            {
                for (i = 0; i < SecondArray.Length; i++) result[i] = array_1._doubles[i] - SecondArray[i];
                for (; i < array_1._doubles.Length; i++) result[i] = array_1._doubles[i];
            }
            if (array_1._doubles.Length <= SecondArray.Length)
            {
                for (i = 0; i < array_1._doubles.Length; i++) result[i] = SecondArray[i] - array_1._doubles[i];
                for (; i < SecondArray.Length; i++) result[i] = (-1) * SecondArray[i];
            }

            return result;
        }

        public static double[] SubstractionOfArrays(ArrayFloat array_1, ArrayFloat array_2)
        {
            int length1 = array_1._doubles.Length;
            int length2 = array_2._doubles.Length;
            int maxlength = 0, i;

            if (length1 >= length2 && length1 != 0)
                maxlength = length1;
            else
            {
                if (length2 >= length1 && length2 != 0)
                    maxlength = length2;
            }

            double[] result = new double[maxlength];

            if (array_1._doubles.Length >= array_2._doubles.Length)
            {
                for (i = 0; i < array_2._doubles.Length; i++) result[i] = array_1._doubles[i] - array_2._doubles[i];
                for (; i < array_1._doubles.Length; i++) result[i] = array_1._doubles[i];
            }
            if (array_1._doubles.Length <= array_2._doubles.Length)
            {
                for (i = 0; i < array_1._doubles.Length; i++) result[i] = array_2._doubles[i] - array_1._doubles[i];
                for (; i < array_2._doubles.Length; i++) result[i] = (-1) * array_2._doubles[i];
            }

            return result;
        }

        public static bool IntroductionOfArrays(ArrayFloat array_1, ArrayFloat array_2)
        {
            int i = 0;
            if (array_1._doubles.Length == array_2._doubles.Length)
            {
                while (array_1._doubles[i] == array_2._doubles[i] && i < array_1._doubles.Length - 1)
                    i++;

                if (i == array_1._doubles.Length - 1)
                    return true;
            }
            return false;
        }
    }
}
