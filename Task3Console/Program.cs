using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3Logic;

namespace Task3Console
{
    class Program
    {
        static void InitializeArray(ref int[] array)
        {
            int numberOfElements = 10;
            int minValue = -1000;
            int maxValue = 1000;
            array = new int[numberOfElements];
            Random random = new Random();
            for (int i = 0; i < numberOfElements; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int[] array = null;
                InitializeArray(ref array);
                Console.WriteLine("Original array: "+string.Join(",", array));
                MergeSorter.Sort(array, 0, array.Length - 1);
                Console.WriteLine("Sorted array: "+string.Join(",", array));
                MergeSorter.Sort(null, 0, array.Length - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: "+e.Message);
            }           
        }
    }
}
