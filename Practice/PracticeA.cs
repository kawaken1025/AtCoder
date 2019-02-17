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

			var a = int.Parse(Console.ReadLine());
			string[] input = Console.ReadLine().Split(' ');
			var b = int.Parse(input[0]);
			var c = int.Parse(input[1]);

			var s = Console.ReadLine();
			var ans = a + b + c;

			Console.WriteLine(String.Format("{0} {1}",ans,s));
		}
	}
}
