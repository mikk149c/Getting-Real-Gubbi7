using System;
using System.Collections.Generic;
using ConfigurationData;

namespace CoreDataStructure
{
	internal class IngestStation
	{
		private string stationId;
		private List<Parcel> parcels;
		public string StationId { get { return stationId; } set { stationId = value; } }

		internal string GetData(DataType data, DateTime startTime, DateTime endTime)
		{
			List<Parcel> targetParcels = parcels.FindAll(x => x.Time >= startTime && x.Time < endTime);
			switch (data)
			{
				case DataType.Amount:
					return targetParcels.Count.ToString();
					break;

				case DataType.Volume:
					int volume = 0;
					foreach (Parcel p in targetParcels)
						volume += p.GetVolume();
					return volume.ToString();
					break;

				case DataType.Waight:
					int weight = 0;
					foreach (Parcel p in targetParcels)
						weight += p.Weight;
					return weight.ToString();
			}
			return "n/a";
		}
	}
}