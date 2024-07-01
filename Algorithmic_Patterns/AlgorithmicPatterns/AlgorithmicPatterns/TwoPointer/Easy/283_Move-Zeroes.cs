using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AlgorithmicPatterns.TwoPointer.Easy
{
    public partial class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            // Pointer to track the position to place the next non-zero element
            int position = 0;

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                // If the current element is not zero
                if (nums[i] != 0)
                {
                    // Move the non-zero element to the 'position' index
                    nums[position] = nums[i];
                    // Increment the position for the next non-zero element
                    position++;
                }
            }

            // Fill the remaining positions in the array with zeros
            // This loop runs if there are remaining positions after placing non-zero elements
            while (position < nums.Length)
            {
                nums[position] = 0;
                position++;
            }
        }

    }
}
