using System;
using ConfigurationData;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Controllers
{
	internal static class PrintController
	{
		internal static void PrintConfig(Configuration config)
		{
			List<List<List<string>>> print = new List<List<List<string>>>();

			ParcelDataController parcelData = ParcelDataController.Instance;
			List<DataType> collums = config.Data;
			List<string> stations = parcelData.GetStationNames();
			foreach (string s in stations)
			{
				List<List<string>> currentStation = new List<List<string>>();
				DateTime timePointer = config.StartTime;
				do
				{
					List<string> row = new List<string>();
					foreach (DataType d in collums)
					{
						row.Add(parcelData.GetData(s, d, timePointer, timePointer + config.Interval));
					}
					timePointer += config.Interval;
					currentStation.Add(row);
				} while (timePointer > config.EndTime);
				print.Add(currentStation);
			}

			//Needs print
		}
	}
}