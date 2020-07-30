using System;

namespace RCS_07._27_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

#region TaskMD
        static void TaskMD()
        {
            Console.WriteLine("The program raises base to power.");
            Console.Write("Input integer base: ");
            int nBase = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input integer power: ");
            int power = Convert.ToInt32(Console.ReadLine());

            if (nBase == 0 && power == 0)
                Console.WriteLine("{0} ^ {1} = {2}\n", nBase, power, "Result is undefined");
            else
            {
                double result = RaiseToPower(Convert.ToDouble(nBase), power);
                Console.WriteLine("{0} ^ {1} = {2}\n", nBase, power, result);
            }
        }

        static double RaiseToPower(double nBase, int power)
        {
            int counter = 0;
            double result = 1;
            if (power < 0)
            {
                nBase = 1 / nBase;
                power = -power;
            }

            while(counter < power)
            {
                result *= nBase;
                counter++;
            }

            return result;
        }
        #endregion

#region Task5
        static void Task5()
        {
            int[] intArr = new int[20];
            RandomizeArr(intArr);
            Console.WriteLine("Random Array:");
            PrintArray(intArr);
            Console.WriteLine("\nSorted Array:");
            SortToLargest(intArr);
            PrintArray(intArr);
            Console.WriteLine("");
        }

        static void RandomizeArr(int[] arr)
        {
            Random rand = new Random();
            int counter = 0;
            while (counter < 20)
            {
                arr[counter] = rand.Next(0, 31);
                counter++;
            }           
        }

        static void SortToLargest(int[] arr)
        {
            int j = 0;
            
            while (j <= arr.Length - 2)
            {
                int temp;
                int i = 0;
                while (i <= arr.Length - 2)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                    i++;
                }
                j++;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
                Console.Write(item.ToString() + " ");
        }
#endregion

        static void Task4()
        {
            int i = 1;
            while (i < 5)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
                i++;
            }

            i--;
            while (i > 0)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
                i--;
            }
        }

        static void Task3()
        {
            int input = 0;

            Console.Write("Input integer number 1: ");
            input = Convert.ToInt32(Console.ReadLine());
            int max = input;
            int min = input;

            int i = 2;
            while (i < 11)
            {
                Console.Write("Input integer number {0}: ", i);
                input = Convert.ToInt32(Console.ReadLine());

                if (input > max)
                    max = input;
                if (input < min)
                    min = input;
                i++;
            }
            Console.WriteLine("Max number is {0}", max);
            Console.WriteLine("Min number is {0}", min);
        }

        static void Task2()
        {
            int result = 0;
            int i = 1;
            while (i < 7)
            {
                Console.Write("Input integer number {0}: ", i);
                result += Convert.ToInt32(Console.ReadLine());
                i++;
            }

            Console.WriteLine("Sum of 6 nums is {0}", result);
        }

        static void Task1()
        {
            int result = 0;
            int i = 1;
            while (i < 11)
            {
                result += i++;
            }

            Console.WriteLine("Sum from 1 to 10 is {0}", result);
        }
    }
}
