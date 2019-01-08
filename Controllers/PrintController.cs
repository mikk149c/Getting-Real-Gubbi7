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
		// Metode der skal have et configuration objekt som input
		internal static void PrintConfig(Configuration config)
		{
			// der oprettes en tom string med navnet "print"
			string print = string.Empty;

			// oprettes objekt ved navn "parcelData" som sættes = singleton instansen "ParcelDataController.Instance"
			ParcelDataController parcelData = ParcelDataController.Instance;

			// der oprettes en liste over collumns af enum typen. "Weight, volume og Amount"
			List<DataType> collums = config.Data;
			// der oprettes en list eover stations af typen string.
			// Henter liste over station navne vha. metoden "GetStationNames()
			List<string> stations = parcelData.GetStationNames();
			// foreach loop per indføring (string name)
			foreach (string s in stations)
			{
				// skriver til første linje: indføring: + stationsnavn og linjeskift
				print += $"Indføring: {s}\r\n";

				// der defineres et tidspunkt i en dateTime variabel.
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