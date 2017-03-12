using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Logic
{
    /// <summary>
    /// Class providing merge sort for array of integer values
    /// </summary>
    public class MergeSorter
    {      
        #region Public Methods
        /// <summary>
        /// Sorts the elements in a range of elements in an array of integers
        /// </summary>
        /// <param name="array">the array to sort</param>
        /// <param name="leftIndex">the starting index of the range to sort.</param>
        /// <param name="rightIndex">the ending index of the range to sort.</param>
        public static void Sort(int[] array, int leftIndex, int rightIndex)
        {
            if (array == null)
                throw new ArgumentNullException();
            if ((leftIndex < 0) || (leftIndex >= array.Length))
                throw new ArgumentOutOfRangeException();
            if ((rightIndex < 0) || (rightIndex >= array.Length))
                throw new ArgumentOutOfRangeException();
            if (leftIndex < rightIndex)
            {
                int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                Sort(array, leftIndex, middleIndex);
                Sort(array, middleIndex + 1, rightIndex);
                Merge(array, leftIndex, middleIndex, rightIndex);
            }
        }
        #endregion
        #region Private Methods
        /// <summary>
        /// Copies all of elements from an array starting at the specified source index and pastes them to another array starting at the specified destination index saving the destination index value
        /// </summary>
        /// <param name="sourceArray">the array that contains the data to copy</param>
        /// <param name="destinationArray">the array that receives the data.</param>
        /// <param name="sourceIndex">a 32-bit integer that represents the index in the sourceArray at which copying begins</param>
        /// <param name="destinationIndex">a 32-bit integer that represents the index in the destinationArray at which storing begins</param>
        private static void CopyRestOfArray(int[] sourceArray, int[] destinationArray, int sourceIndex, ref int destinationIndex)
        {
            if (sourceArray == null)
                throw new ArgumentNullException();
            if (destinationArray == null)
                throw new ArgumentNullException();
            while (sourceIndex < sourceArray.Length)
            {
                destinationArray[destinationIndex] = sourceArray[sourceIndex];
                sourceIndex++;
                destinationIndex++;
            }
        }
        /// <summary>
        /// Merges two parts of array, the left part determined by starting and ending indexes and the right part begins after the left one ends
        /// </summary>
        /// <param name="array">an array which contains parts</param>
        /// <param name="leftIndex">statring index of the left part</param>
        /// <param name="middleIndex">ending index of the letf part</param>
        /// <param name="rightIndex">ending index of the right part</param>
        private static void Merge(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            if (array == null)
                throw new ArgumentNullException();
            if ((leftIndex < 0) || (leftIndex >= array.Length))
                throw new ArgumentOutOfRangeException();
            if ((rightIndex < 0) || (rightIndex >= array.Length))
                throw new ArgumentOutOfRangeException();
            if (middleIndex < leftIndex)
                throw new ArgumentException();
            if (rightIndex <= middleIndex)
                throw new ArgumentException();
            int i, j, k;
            int leftPartLength = middleIndex - leftIndex + 1;
            int rightPartLength = rightIndex - middleIndex;
            int[] leftPart = new int[leftPartLength];
            int[] rightPart = new int[rightPartLength];

            for (i = 0; i < leftPartLength; i++)
                leftPart[i] = array[leftIndex + i];
            for (j = 0; j < rightPartLength; j++)
                rightPart[j] = array[middleIndex + 1 + j];

            i = 0;
            j = 0;
            k = leftIndex;
            while (i < leftPartLength && j < rightPartLength)
            {
                if (leftPart[i] <= rightPart[j])
                {
                    array[k] = leftPart[i];
                    i++;
                }
                else
                {
                    array[k] = rightPart[j];
                    j++;
                }
                k++;
            }

            CopyRestOfArray(leftPart, array, i, ref k);
            CopyRestOfArray(rightPart, array, j, ref k);
        }
        #endregion
    }
}
