using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4Logic
{
    /// <summary>
    /// Class providing alphabetization of the result of string concatenation without char duplications
    /// </summary>
    public class StringAlphabetizer
    {
        #region Public Methods
        /// <summary>
        /// Concatenates two strings, removes char duplications and alphabetizes the result
        /// </summary>
        /// <param name="firstString">the first string to operate</param>
        /// <param name="secondString">the second string to operate</param>
        /// <returns>the string which is alphabetized concatenation of two strings without char duplications</returns>
        public static string ConcatAndAlphabetize(string firstString, string secondString)
        {
            if ((firstString == null) || (secondString == null))
                throw new ArgumentNullException();
            Regex regex = new Regex("^[a-z]+$");
            if (!(regex.IsMatch(firstString)) || !(regex.IsMatch(secondString)))
                throw new ArgumentException();
            string bufferString = string.Concat(firstString, secondString);
            char[] charArray = bufferString.Distinct().ToArray();
            Array.Sort(charArray);
            return new string(charArray);
        }
        #endregion
    }
}
