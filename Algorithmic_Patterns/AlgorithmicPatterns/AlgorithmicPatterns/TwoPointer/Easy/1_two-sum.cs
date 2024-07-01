using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicPatterns.TwoPointer.Easy
{
    public partial class Solution
    {
        /// <summary>
        /// Solve by Dictionary 
        /// A dictionary allows O(1) average-time complexity for lookups, making it ideal for problems requiring frequent existence checks.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            // Dictionary to store the value and its index
            Dictionary<int, int> dic = new Dictionary<int, int>();

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the complement (difference needed to reach the target)
                int difference = target - nums[i];

                // Check if the complement exists in the dictionary
                if (dic.ContainsKey(difference))
                {
                    // If found, return the indices of the current number and the complement
                    return new int[] { dic[difference], i };
                }

                // Store the current number and its index in the dictionary
                // Using dic[nums[i]] = i allows updating the dictionary if the number already exists
                dic[nums[i]] = i;
            }

            // Return [-1, -1] if no solution is found (though problem guarantees exactly one solution)
            return new int[] { -1, -1 };
        }

    }
}
