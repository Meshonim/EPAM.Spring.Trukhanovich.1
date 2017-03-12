using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Logic;

namespace Task2Console
{
    class Program
    {
        static void InitializeArrays(int[][] arrays)
        {
            arrays[0] = new int[] { 1, 2, 1, 5, 0, 4 };
            arrays[1] = new int[] { 1, 2, 5 };
            arrays[2] = new int[0];
            arrays[3] = null;
        }

        static void TestArrays(int[][] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                try
                {
                    TestArray(arrays[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception in array {i}: " + e.Message);
                }
            }
        }

        static void TestArray(int[] array)
        {
            try
            {
                int length = (array == null) ? 0 : array.Length - 1;
                Console.WriteLine("Index of central element: " + 
                                  CentralElementOfArray.FindIndexOfCentalElement(array).ToString());
                Console.WriteLine(string.Join(",", array));
            }
            catch
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            int arraysCount = 4;
            int[][] arrays = new int[arraysCount][];
            InitializeArrays(arrays);
            TestArrays(arrays);
        }
    }
}
