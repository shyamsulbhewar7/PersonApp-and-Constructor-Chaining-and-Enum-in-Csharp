using System;
namespace ConsoleApplication1
{
	enum month
	{
		jan = 1,
		feb = 2,
		mar = 3,
		apr = 4,
		may = 5
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The value of jan in month " + "enum is " + (int)month.jan);
			Console.WriteLine("The value of feb in month " + "enum is " + (int)month.feb);
			Console.WriteLine("The value of mar in month " + "enum is " + (int)month.mar);
			Console.WriteLine("The value of apr in month " + "enum is " + (int)month.apr);
			Console.WriteLine("The value of may in month " + "enum is " + (int)month.may);
		}
	}
}
