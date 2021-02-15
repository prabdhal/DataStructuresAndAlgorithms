using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematical
{
	class MathProblems
	{
		public static void PrintPat(int N)
		{
			if (N < 1 || N > 40)
			{
				Console.WriteLine("lengthOfPattern value must be between 1 to 40");
				return;
			}

			int x = N;

			for (int i = N; i > 0; i--)
			{
				x = N;
				for (int j = x; j > 0; j--)
				{
					for (int k = i; k > 0; k--)
					{
						Console.Write(x);
					}
					x--;
				}
				Console.Write(" ");
			}
			
			// print lengthOfPattern times amount of numbers then -1 and repeat until value 1 is reached
		}
	}
}
// 333222111
// 332211
// 321
// 3

// 2211
// 21
