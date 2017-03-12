using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
    /// <summary>
    /// Class providing find of maximum array element
    /// </summary>
    public class MaximumElementOfArray
    {
        #region Public Methods
        /// <summary>
        /// Finding maximum array element recursively
        /// </summary>
        /// <param name="array">an array to determine the maximum value of</param>
        /// <param name="index">ending array index of the finding</param>
        /// <returns>maximum element of array</returns>
        public static int FindMaximumElementOfArray(int[] array, int index)
        {
            if (array == null)
                throw new ArgumentNullException();
            if ((index < 0) || (index >= array.Length))
                throw new ArgumentOutOfRangeException();
            if (index == 0)
                return array[index];
            return Math.Max(FindMaximumElementOfArray(array, index - 1), array[index]);
        }
        #endregion


    }
}
