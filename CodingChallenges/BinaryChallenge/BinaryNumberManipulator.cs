using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryChallenge
{
    class BinaryNumberManipulator
    {
        /// <summary>
        /// Converts an integer to binary
        /// </summary>
        /// <param name="number">The integer to convert</param>
        /// <returns>The binary number as string</returns>
        internal static string GetBinary(int number) => Convert.ToString(number, 2);

        /// <summary>
        /// Returns the number of 1s in a binary number
        /// </summary>
        /// <param name="binary">The binary number</param>
        /// <returns>The number of 1s in binary</returns>
        internal static int GetNumberOfOnesInABinary(string binary)
        {
            int onesCount = 0;
            foreach (char item in binary.ToCharArray())
            {
                if (item == '1')
                {
                    onesCount++;
                }
            }
            return onesCount;
        }
    }
}
