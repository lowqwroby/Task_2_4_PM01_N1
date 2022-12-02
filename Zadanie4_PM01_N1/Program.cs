using System;

namespace Variant10
{
	class Program
	{
		static void Main()
		{
			for (int i = 1; i <= 5; i++, Console.WriteLine())
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(" " + j);
				}
			}
		}
	}
}