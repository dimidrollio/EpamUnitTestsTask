using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringies
{
	public class Program
	{
		public static void Main()
		{
			var d = new StringsInfo();
			int i = d.EqualLettersCount("а22222ооkjkkjkjkjkjkjkjkjkjkjkjmKKKkkkkkkkmm");
			Console.WriteLine(i);
		}
	}
}
