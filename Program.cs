using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Class_241213
{
    internal class Program
    {
        static void F01(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += random.Next(0, 51);
            }
        }

        static int F02(int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        static double F03(int[] array)
        {
            double average = 0;

            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }

            return (average / array.Length);
        }


        static int[] F04(int[] array) {
            
            int[] odds = new int[10]; //IndexOutOfRange Exception!

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    odds[i] = (array[i] + 1);
                }
                else
                {
                    odds[i] = array[i];
                }
            }

            return odds;
        }

        static void F05(int[] array)
        {
            Console.WriteLine($"There are {F02(array)} positive numbers"); //Positive?
            Console.WriteLine($"The average of array's elements is {F03(array)}");

            Console.WriteLine("Odd numbers made from the array: ");
            foreach(int i in F04(array))
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            F01(numbers);
            F05(numbers);
        }
    }
}
