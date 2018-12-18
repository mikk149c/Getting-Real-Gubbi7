using System;
using System.Collections.Generic;
using System.Text;

namespace Gubbi7_Menu
{
	public static class MenuUtility
	{

		public static bool ConfirmAction(string action)
		{
			Console.WriteLine($"Er du sikker på du vil {action}.\n'Y' for ja 'N' for nej");
			switch (Console.ReadKey(true).Key)
			{
				case ConsoleKey.Y:
					return true;
				case ConsoleKey.N:
					return false;
				default:
					return false;


			}
		}
		public static void SearchMenu(List<string> dataTypes, out string output)
		{
			output = "";
			ConsoleKeyInfo key;
			do
			{
				int inputLine = Console.CursorTop;
				Console.WriteLine(output);
				foreach (string s in dataTypes)
					if (s.StartsWith(output))
						Console.WriteLine(s);
				key = Console.ReadKey();
				if (key.Key.Equals(ConsoleKey.Backspace))
				{
					if (output.Length > 0)
						output = output.Substring(0, output.Length - 1);
				}
				else if (!key.Key.Equals(ConsoleKey.Enter))
					output += key.KeyChar;
				for (int i = inputLine; i < Console.WindowHeight; i++)
					ClearLine(i);
				Console.SetCursorPosition(0, inputLine);
			} while (!key.Key.Equals(ConsoleKey.Enter));
		}
		public static void ClearLine(int i)
		{
			int currentLineCursor = Console.CursorTop;
			Console.SetCursorPosition(0, i);
			Console.Write(new string(' ', Console.WindowWidth));
			Console.SetCursorPosition(0, currentLineCursor);
		}
	}
}
