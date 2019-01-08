using System;
using System.Collections.Generic;
using System.Text;
using ConfigurationData;
using CoreDataStructure;

namespace Controllers
{
	public class ParcelDataController
	{
		private static ParcelDataController instance;
		private IngestStationRepo ingestStationRepo;

		private ParcelDataController()
		{
			ingestStationRepo = new IngestStationRepo();
		}
		// metode som returnerer liste over navnene på indføringstationer
		internal List<string> GetStationNames()
		{
			List<string> names = new List<string>();
			foreach (IngestStation i in ingestStationRepo.IngestStations)
				names.Add(i.StationId);
			return names;
		}
		// Singleton, returner en specifik instans.
		public static ParcelDataController Instance
		{
			get
			{
				if (instance == null)
					instance = new ParcelDataController();
				return instance;
			}
		}
		// Henter en liste af objekter (indføringsstationer) 
		internal string GetData(string station, DataType data, DateTime startTime, DateTime endTime)
		{
			return ingestStationRepo.getData(station, data, startTime, endTime);
		}
		// pakke på specifik terminal ID (indføring)
		internal void RegisterParcel(string termianlId, DateTime date, int weight, int length, int heaight, int width)
		{
			ingestStationRepo.RegisterParcel(termianlId, date, weight, length, heaight, width);
		}
	}
}
