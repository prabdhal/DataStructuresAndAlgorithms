using System;
using System.IO;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word...");
            string word = Console.ReadLine();

            string reverseStringIgnoringSpecialChars = ReverseStringIgnoringSpecialChars(word);
            string reverseEntireString = ReverseEntireString(word.ToCharArray());
            string reverseWordOrder = ReverseWordOrder(word);
            bool palindromeCheck = PalindromeCheck(word);
            string reverseWords = ReverseWords(word);
            CharacterOccuranceCounter(word);
            string removeDuplicateOccurances = RemoveDuplicateOccurances(word);
            FindAllSubstrings(word);

            Console.WriteLine("Reverse String ignoring specials chars - {0}, Reverse entire string - {1}, Reverse words of an entire string - {2}, " +
                "Palindrome check - {3}, Reverse words - {4}, Remove duplicate occurances - {5}",
                reverseStringIgnoringSpecialChars, reverseEntireString, reverseWordOrder, palindromeCheck, reverseWords, removeDuplicateOccurances);
        }

        // Reverse entire string
        public static string ReverseEntireString(string str)
        {
            string given = str;
            string result = "";

            // reverse each letter, ignoring special characters
            for (int i = given.Length - 1; i >= 0; i--)
            {
                // add char into temp string
                result += given[i];
            }

            return result;
        }

        // Reverse entire string - Alternative
        public static string ReverseEntireString(char[] str)
        {
            char[] given = str;
            string result = "";

            // Initialize right and left pointers
            int r = given.Length - 1, l = 0;

            // Traverse string from both ends
            while (l < r)
            {
                char temp = given[r];
                given[r] = given[l];
                given[l] = temp;
                l++;
                r--;
            }

            for (int i = 0; i < given.Length; i++)
            {
                result += given[i];
            }

            return result;
        }

        // Reverse a string without affecting special characters
        //Ex. Input: str = "a,b$c"  output str = "c,b$a"
        public static string ReverseStringIgnoringSpecialChars(string str)
        {
            char[] given = str.ToCharArray();
            string result = "";

            // Initialize left and right pointers
            int r = given.Length - 1, l = 0;

            // Traverse string from both ends until
            // 'l' and 'r'
            while (l < r)
            {
                // ignore all special characters
                if (!char.IsLetter(given[l]))
                    l++;
                else if (!char.IsLetter(given[r]))
                    r--;
                else
                {
                    char temp = given[l];
                    given[l] = given[r];
                    given[r] = temp;
                    l++;
                    r--;
                }
            }

            for (int i = 0; i < given.Length; i++)
            {
                result += given[i];
            }

            return result;
        }

        // Reverse the word order
        public static string ReverseWordOrder(string str)
        {
            string given = str;
            string result = "";

            string[] givenAry = given.Split(' ');

            for (int i = givenAry.Length - 1; i >= 0; i--)
            {
                result += givenAry[i];
                if (i > 0) result += ' ';
            }

            return result;
        }

        // Indicate whether a string is Palindrome
        public static bool PalindromeCheck(string str)
        {
            string given = str;

            int r = given.Length - 1, l = 0;

            while (l < r)
            {
                if (given[l] != given[r])
                    return false;

                l++;
                r--;
            }
            return true;
        }

        // Reverse only words of a string
        public static string ReverseWords(string str)
        {
            string given = str;
            string result = "";

            string[] givenAry = str.Split(' ');


            for (int i = 0; i < givenAry.Length; i++)
            {
                int r = givenAry[i].Length - 1, l = 0;
                string word = givenAry[i];

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    result += word.Substring(j, 1);
                }

                if (i < givenAry.Length - 1)
                    result += ' ';

                Console.WriteLine(result);
            }

            return result;
        }

        // Count the occurence of each character in a string
        public static void CharacterOccuranceCounter(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (c != ' ')
                {
                    if (!charCount.ContainsKey(c))
                    {
                        charCount.Add(c, 1);
                    }
                    else
                    {
                        charCount[c]++;
                    }
                }
            }
            foreach (var c in charCount)
            {
                Console.WriteLine("{0} occurances of the character {1}", c.Value, c.Key);
            }
        }

        // Remove duplicate characters from a string
        public static string RemoveDuplicateOccurances(string str)
        {
            string given = str;
            string result = "";

            for (int i = 0; i < given.Length; i++)
            {
                if (result.Contains(given[i])) continue;
                result += given[i];
            }

            return result;
        }

        // Find all possible substring of a given string
        public static void FindAllSubstrings(string str)
        {
            string given = str;

            // substring 1 value at a time all the way to length value
            for (int i = 0; i < given.Length; i++)
            {
                for (int j = 1; j <= (given.Length - i); j++)
                {
                    Console.WriteLine("Substring - {0}", given.Substring(i, j));
                }
            }
        }
    }
}
