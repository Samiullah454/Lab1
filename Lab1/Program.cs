using System;
using System.Linq;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayofnumbers = { -1, 5, 0, 9, 98, 76,-100 };
             
            Program p = new Program();
           int maximumNumber= p.FindMaximumNumber(arrayofnumbers);
            Console.WriteLine();
            Console.WriteLine($"Maximum Number is ::"+maximumNumber);
            int minimumNumber = p.FindMinimumNumber(arrayofnumbers);
            Console.WriteLine();
            Console.WriteLine($"Miniimum Number is ::" + minimumNumber);
            int sum=p.FindSum(arrayofnumbers);
            Console.WriteLine($"Sum is ::" + sum);
            double avg = p.FindAvg(arrayofnumbers);
            Console.WriteLine($"Average is ::" + avg);
        }
        public int FindMaximumNumber(int[] array)
        {
            int lengthofarray = array.Length;
            int max = array[0];
            for(int i = 0; i < lengthofarray; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }

            /*
             * int i;
            for ( i = 0; i < lengthofarray; ++i)
            {
                int currentElement = array[i];
                int k = i - 1;
                while (k >= 0 && array[k] > currentElement)
                {
                   array[k + 1] = array[k];
                    k--;
                }
                array[k + 1] = currentElement
            }
           
            for ( i = 0; i < lengthofarray; ++i)
                Console.Write(array[i] + " ");
            int maximumnumber = array[lengthofarray-1];*/
            return max;
        }
        public int FindMinimumNumber(int[] array)
        {
            int lengthofarray = array.Length;
            int mini = array[0];
            for (int i = 0; i < lengthofarray; i++)
            {
                if (array[i] < mini)
                {
                    mini = array[i];
                }
            }
            /*int i;
            for (i = 0; i < lengthofarray; ++i)
            {
                int currentElement = array[i];
                int k = i - 1;
                while (k >= 0 && array[k] < currentElement)
                {
                    array[k + 1] = array[k];
                    k--;
                }
                array[k + 1] = currentElement;
            }

            for (i = 0; i < lengthofarray; ++i)
                Console.Write(array[i] + " ");
            int maximumnumber = array[lengthofarray-1];*/
            return mini;
        }
      public int FindSum(int[] array)
        { int sum=0;
            foreach(var item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        public double FindAvg(int[] array)
        {
            int sum = 0;
            double avg;
            int length = array.Length;
            foreach (var item in array)
            {
                sum = sum + item;
            }
            avg = sum / length;
            return avg;
        }

    }
}
