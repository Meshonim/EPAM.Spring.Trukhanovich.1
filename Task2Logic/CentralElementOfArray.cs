using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    /// <summary>
    /// Class providing find an index of array element such that its prefix sum equals its suffix sum 
    /// </summary>
    public class CentralElementOfArray
    {
        #region Public Methods
        /// <summary>
        /// Find an index of array element such that its prefix sum equals its suffix sum 
        /// </summary>
        /// <param name="array">an array to determine the central value index of</param>
        /// <returns>index of cental element of array</returns>
        public static int FindIndexOfCentalElement (int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            int length = array.Length;
            int left = 0;
            int right = array.Sum();
            for (int i = 0; i < length; i++)
            {
               int currentElement = array[i];
               right = right - currentElement;
               if (left == right)
               {
                    return i;
               }
               left = left + currentElement;
            }
            return -1;
        }
        #endregion
    }
}
