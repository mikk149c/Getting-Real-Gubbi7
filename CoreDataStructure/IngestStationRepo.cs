using System;
using System.Collections.Generic;
using System.Text;
using ConfigurationData;

namespace CoreDataStructure
{
	public class IngestStationRepo
	{
		private List<IngestStation> ingestStations;

		public IngestStationRepo()
		{
			ingestStations = new List<IngestStation>();
		}

		public List<IngestStation> IngestStations { get { return ingestStations; } set { ingestStations = value; } }

		public string getData(string station, DataType data, DateTime startTime, DateTime endTime)
		{
			return IngestStations.Find(x => x.StationId == station).GetData
				(
				data,
				startTime,
				endTime
				);
		}

		public void RegisterParcel(string termianlId, DateTime date, int weight, int length, int height, int width)
		{
			// Ingestation objekt oprettes, hvis terminalID ikke eksisterer i objektlisten "Ingeststations"
			//oprettes et objekt med stationen. (LAMBDA i if statement)
			IngestStation station;
			if ((station = IngestStations.Find(x => x.StationId.Equals(termianlId))) == null)
			{
				station = new IngestStation(termianlId);
				IngestStations.Add(station);
			}
			// Herefter registreres input data som metoden bruger på den pågældende stationsID objekt.
			station.RegisterParcel(date, weight, length, height, width);
		}
	}
}
