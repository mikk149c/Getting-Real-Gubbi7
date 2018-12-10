using System;
using System.Collections.Generic;
using System.Text;

namespace Gubbi7_Menu
{
	public static class MenuUtility
	{
		public static bool ConfirmAction(string handling)
		{
			Console.WriteLine($"Er du sikker på du vil {handling}.\n'Y' for ja 'N' for nej");
			switch (Console.ReadKey().Key)
			{
				case ConsoleKey.Y:
					return true;
				case ConsoleKey.N:
					return false;
				default:
					return false;


			}
		}
	}
}
