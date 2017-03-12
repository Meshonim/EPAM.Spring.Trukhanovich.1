using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;

namespace Task1Console
{
    class Program
    {     
        static void InitializeArrays(int[][] arrays)
        {
            int numberOfElements = 10;
            int minValue = -1000;
            int maxValue = 1000;
            arrays[0] = new int[numberOfElements];
            Random random = new Random();
            for (int i = 0; i < numberOfElements; i++)
            {
                arrays[0][i] = random.Next(minValue, maxValue);
            }
            arrays[1] = new int[0];
            arrays[2] = null;
        }

        static void TestArrays (int[][] arrays)
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

        static void TestArray (int[] array)
        {
            try
            {
                int length = (array == null) ? 0 : array.Length-1;
                Console.WriteLine("Max: "+ MaximumElementOfArray.FindMaximumElementOfArray(array, length).ToString());
                Console.WriteLine(string.Join(",", array));
            }
            catch
            {
                throw;
            }          
        }

        static void Main(string[] args)
        {
                int arraysCount = 3;
                int[][] arrays = new int[arraysCount][];
                InitializeArrays(arrays);
                TestArrays(arrays);            
            }           
        }
    }

