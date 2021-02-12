using System;
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
            string reverseString = ReverseString(word.ToCharArray());
            Console.Write(reverseStringIgnoringSpecialChars);

            Console.WriteLine("Reverse String ignoring specials chars - {0}, Reverse entire string - {1}", reverseStringIgnoringSpecialChars, reverseString);
        }

        // Reverse entire string
        public static string ReverseString(string str)
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
        public static string ReverseString(char[] str)
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

        
    }
}
