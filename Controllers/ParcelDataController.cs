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

		internal List<string> GetStationNames()
		{
			throw new NotImplementedException();
		}

		public static ParcelDataController Instance
		{
			get
			{
				if (instance == null)
					instance = new ParcelDataController();
				return instance;
			}
		}

		internal string GetData(string station, DataType data, DateTime startTime, DateTime endTime)
		{
			return ingestStationRepo.getData(station, data, startTime, endTime);
		}
	}
}
