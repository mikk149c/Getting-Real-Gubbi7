using System;
using System.Collections.Generic;
using System.Text;

namespace Gubbi7_Menu
{
	public static class MenuUtility
	{
		//Metode til confirmation af action 
		public static bool ConfirmAction(string action)
		{
			Console.WriteLine($"Er du sikker på du vil {action}.\n'Y' for ja 'N' for nej");
			switch (Console.ReadKey(true).Key)
				// input defineres udfra basic consoleKey enums som returnerer en false eller true bool værdi udfra bruger input. 
			{
				case ConsoleKey.Y:
					return true;
				case ConsoleKey.N:
					return false;
				default:
					return false;


			}
		}
		// Metode der skriver overenstemmende søge resultater i forhold til brugerens input
		public static void SearchMenu(List<string> dataTypes, out string output)
		{
			output = "";
			ConsoleKeyInfo key;
			// foretages i et while loop indtil consolekey enum værdien bliver sat til "Enter"
			// der forekommer altså 2 "Enter" loops som skal stoppes for at bryde loops
			// Do while loop med Enter og en "Else if" inde i do while loopet.
			do
			{
				int inputLine = Console.CursorTop;
				Console.WriteLine(output);
				foreach (string s in dataTypes)
					if (s.StartsWith(output))
						Console.WriteLine(s);
				key = Console.ReadKey();
				// kode udføres hvis der klikkes på backspace, fjerner en char fra den pågældende string
				if (key.Key.Equals(ConsoleKey.Backspace))
				{
					if (output.Length > 0)
						output = output.Substring(0, output.Length - 1);
				}
				// kode udføres så længe der ikke indtastes Enter, tilføjer input til string.
				else if (!key.Key.Equals(ConsoleKey.Enter))
					output += key.KeyChar;
				// skriver til korrekt linje.
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
