using System;
using System.Collections.Generic;
using System.Text;
using ConfigurationData;

namespace CoreDataStructure
{
	public class IngestStationRepo
	{
		private List<IngestStation> ingestStations;

		public string getData(string station, DataType data, DateTime startTime, DateTime endTime)
		{
			return ingestStations.Find(x => x.StationId == station).GetData
				(
				data,
				startTime,
				endTime
				);
		}
	}
}
