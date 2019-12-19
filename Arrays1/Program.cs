using System;

namespace Arrays1
{
    class Program
    {
        static void MaxArrAbs(ref double i, params double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                i = 0;
                return;
            }
            else
            {
                if (arr.Length == 1)
                {
                    i = arr[0];
                    return;
                }
            }
            i = arr[0];
            for (int j = 0; j < arr.Length; j++)
                if (Math.Abs(arr[j]) > i)
                    i = j;
        }
        static void MaxArr(ref double i, params double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                i = 0;
                return;
            }
            else
            {
                if (arr.Length == 1)
                {
                    i = arr[0];
                    return;
                }
            }
            i = arr[0];
            for (int j = 1; j < arr.Length; j++)
                if (arr[j] > i)
                    i = arr[j];
        }

        static double sumOfNegativeElemInMassive(params double[] arr)
        {
            
            double sum = 0;
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                return sum;
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        sum += arr[i];
                    }
                }
                return sum;
            }
        }
        static double sumOfElemInMassive(params double[] arr)
        {

            double sum = 0;
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                return sum;
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    var n = Convert.ToString(arr[i]);
                    if (!n.Contains("."))
                    {
                        sum++;
                    }
                }
                return sum;
            }
        }
        static void indexOfMaxElem(ref int index, params double[] arr)
        {
            double a = 0;
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                return;
            }
            else
            {
         
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > a)
                {
                    a = arr[i];
                    index = i;
                }
            }
        }   
        static void SumOfIndexElem(ref int index, params double[] arr)
        {

            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                return;
            }
            else
            {

            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    index += i;
                }
            }
        }
        static void Main(string[] args)
        {
            int  indexOfMaxElemInMassive = 0, SumIndexElem=0;
            double sumOfNegativeElem = 0, sumInMassive = 0, maxElem = 0, MaxElemAbs = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            Random ran = new Random();
            for (int i = 0; i < 8; i++)
                array[i] = ran.Next(-100, 100)+ Math.Round(ran.NextDouble(), 1)*(ran.Next(0,2)== 1 ? 1 : 0);
            Console.WriteLine("Массив arr1: \n");
            foreach (double i in array)
                Console.Write("{0} ", i);
            Console.WriteLine("\n");
            sumOfNegativeElem = sumOfNegativeElemInMassive(array);
            Console.WriteLine("Сума отрицательных едементов масива: {0} ", sumOfNegativeElem);
            MaxArr(ref maxElem, array);
            Console.WriteLine("Максимум: {0}", maxElem);
            indexOfMaxElem(ref indexOfMaxElemInMassive, array);
            Console.WriteLine("Индекс максимального елемента: {0}", indexOfMaxElemInMassive);
            MaxArrAbs(ref MaxElemAbs, array);
            Console.WriteLine("Индекс максимального по модулю елемента: {0}", MaxElemAbs);
            SumOfIndexElem(ref SumIndexElem, array);
            Console.WriteLine("Сумма индексов положительных чисел: {0}", SumIndexElem);
            sumInMassive = sumOfElemInMassive(array);
            Console.WriteLine("Количество целых чисел: {0}", sumInMassive);
            Console.ReadLine();
        }
    }
}

