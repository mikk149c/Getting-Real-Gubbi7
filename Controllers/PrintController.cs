using System;
using ConfigurationData;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Controllers
{
	internal static class PrintController
	{
		internal static void PrintConfig(Configuration config)
		{
			string print = string.Empty;

			ParcelDataController parcelData = ParcelDataController.Instance;
			List<DataType> collums = config.Data;
			List<string> stations = parcelData.GetStationNames();
			foreach (string s in stations)
			{
				print += $"Indføring: {s}\r\n";
				DateTime timePointer = config.StartTime;
				do
				{
					foreach (DataType d in collums)
					{
						string str = parcelData.GetData(s, d, timePointer, timePointer + config.Interval);
						print += RightAlign(str, 15);
					}
					print += "\r\n";
					timePointer += config.Interval;
				} while (timePointer < config.EndTime);
				print += "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
				Console.WriteLine(s);
			}
			StreamWriter file = File.CreateText("out.txt");
			file.Write(print);
			file.Dispose();
			//Console.WriteLine(print);
			//Console.ReadKey();
		}

		private static string RightAlign(string str, int fieldSize)
		{
			string ret = string.Empty;
			ret += new string(' ', fieldSize - str.Length);
			ret += str;
			return ret;
		}
	}
}