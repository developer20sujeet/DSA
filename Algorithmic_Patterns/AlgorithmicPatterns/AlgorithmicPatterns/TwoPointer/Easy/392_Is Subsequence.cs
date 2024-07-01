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
        /// Time complexity: O(n + m), where n is the length of s and m is the length of t.
        /// Space complexity: O(1)
        /// Algorithm used: Two Pointer
        /// Algorithmic coding pattern: Two Pointer
        /// Data structure used: Array
        /// Company name: Commonly asked in various companies
        /// Central point:
        ///     1. Use two pointers to iterate through s and t.
        ///     2. Move the pointer in s when characters match in both s and t.
        ///     3. If the pointer in s reaches the end, return true.
        /// </summary>
        public bool IsSubsequence(string s, string t)
        {
            // Step 1: Initialize pointers
            int i = 0, j = 0;

            // Step 2: Traverse string t using pointer j
            while (i < s.Length && j < t.Length)
            {
                // Step 2.1: Check if characters match
                if (s[i] == t[j])
                {
                    i++; // Move pointer i to the next character in s
                }
                j++; // Always move pointer j to the next character in t
            }

            // Step 3: Check if all characters in s were found in t in order
            return i == s.Length;
        }
    }
}
