using System;
using System.IO;
using System.Collections.Generic;
using Mathematical;

namespace DataStructuresAndAlgorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkedList list = new LinkedList();
			Node node1 = new Node(1);
			Node node2 = new Node(2);
			Node node3 = new Node(3);
			Node node4 = new Node(4);
			Node node5 = new Node(5);
			Node node6 = new Node(10);
			list.AddTail(node1);
			list.AddTail(node2);
			list.AddTail(node3);
			list.AddTail(node4);
			list.AddTail(node5);
			list.AddMiddle(node6);
			list.RemoveHead();
			list.RemoveHead();
			list.RemoveHead();
			list.PrintNodes();

			MathProblems.PrintPat(3);
			Console.WriteLine("Please enter a word...");
			string word = Console.ReadLine();

			string reverseStringIgnoringSpecialChars = ReverseStringIgnoringSpecialChars(word);
			string reverseEntireString = ReverseEntireString(word.ToCharArray());
			string reverseWordOrder = ReverseWordOrder(word);
			bool palindromeCheck = PalindromeCheck(word);
			string reverseWords = ReverseWords(word);
			string removeDuplicateOccurances = RemoveDuplicateOccurances(word);

			// Void Return-Type Methods
			CharacterOccuranceCounter(word);
			FindAllSubstrings(word);

			// Int Array Methods
			int[] intAry = { 1, 2, 3, 4, 5 };
			ShiftIntToLeft(intAry);

			Console.Write("ReverseStringIgnoringSpecialChars - {0},\n" +
				"ReverseEntireString - {1},\n" +
				"ReverseWordOrder - {2},\n" +
				"PalindromeCheck - {3},\n" +
				"ReverseWords - {4},\n" +
				"RemoveDuplicateOccurances - {5}\n",
				reverseStringIgnoringSpecialChars, 
				reverseEntireString, 
				reverseWordOrder, 
				palindromeCheck, 
				reverseWords, 
				removeDuplicateOccurances);
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
			Console.WriteLine("-----Character Occurances of the string '{0}'-----", str);
			foreach (var c in charCount)
			{
				Console.WriteLine("{0} occurances of the character {1}", c.Value, c.Key);
			}
			Console.WriteLine("-------------------------------");
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

			Console.WriteLine("------The substrings for '{0}'------", given);
			// substring 1 value at a time all the way to length value
			for (int i = 0; i < given.Length; i++)
			{
				for (int j = 1; j <= (given.Length - i); j++)
				{
					Console.WriteLine("Substring - {0}", given.Substring(i, j));
				}
			}
			Console.WriteLine("-------------------------------", given);
		}

		// Perform a left circular rotation of an array (shift characters to the left by 1)
		public static void ShiftIntToLeft(int[] numbers)
		{
			int[] given = numbers;
			int[] result = new int[numbers.Length];

			// add all ints into result array starting from 2nd int
			for (int i = 1; i < given.Length; i++)
			{
				result[i - 1] = given[i];
			}

			// add 1st int to the end of the result array
			result[given.Length - 1] = given[0];

			Console.Write("------Shift the int array [");
			foreach (var num in numbers)
			{
				Console.Write("{0}", num);
			}
			Console.Write("] to the left by one------\n");
			Console.Write("The output is ");
			foreach (var num in result)
			{
				Console.Write("{0}", num);
			}
			Console.WriteLine("\n-------------------------------", given);
		}
	}
}
