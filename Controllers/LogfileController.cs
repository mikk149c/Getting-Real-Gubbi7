using System;
using System.IO;
using CoreDataStructure;

namespace Controllers
{
	public class LogfileController
	{
		private LogfileRepo logfileRepo;

		public void IngestLogfile(string path)
		{
			ParcelDataController parcelData = ParcelDataController.Instance;
			foreach (string s in Directory.GetFiles(Directory.GetCurrentDirectory(), "Taulov*.txt"))
			{
				Console.WriteLine(s);
				string[] lines = File.ReadAllLines(s);
				for (int i = 4; i < lines.Length; i++)
				{
					int weight, length, heaight, width;
					string[] tabs = lines[i].Split('\t');
					DateTime date = DateTime.Parse(tabs[0]);
					string termianlId = tabs[1];
					weight = ParsData(tabs[2]);
					length = ParsData(tabs[3]);
					heaight = ParsData(tabs[4]);
					width = ParsData(tabs[5]);
					parcelData.RegisterParcel(termianlId, date, weight, length, heaight, width);
				}
			}
		}

		private int ParsData(string s)
		{
			if (!s.Length.Equals(0))
				return int.Parse(s);
			else
				return 0;
		}
	}
}