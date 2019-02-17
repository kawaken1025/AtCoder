using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderPrj
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] input = Console.ReadLine().Split(' ');
			int a = int.Parse(input[0]);
			int b = int.Parse(input[1]);

			var ans = a * b;
			if (ans % 2 == 0)
			{
				Console.WriteLine("Even");
			}
			else if (ans % 2 == 1)
			{
				Console.WriteLine("Odd");
			}
		}
	}
}
