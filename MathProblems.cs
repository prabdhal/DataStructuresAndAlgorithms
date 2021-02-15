using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematical
{
	class MathProblems
	{
		public static void PrintPat(int lengthOfPattern)
		{
			if (lengthOfPattern < 1 || lengthOfPattern > 40)
			{
				Console.WriteLine("lengthOfPattern value must be between 1 to 40");
				return;
			}

			int temp = lengthOfPattern;
			for (int i = lengthOfPattern; i > 0; i--)
			{
				temp -= lengthOfPattern - i;
				for (int j = temp; j > 0; j--)
				{
					Console.WriteLine(temp);
				}
				Console.Write("");
			}
		}
	}
}
