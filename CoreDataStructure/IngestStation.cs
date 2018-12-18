using System;
using System.Collections.Generic;
using ConfigurationData;

namespace CoreDataStructure
{
	public class IngestStation
	{
		private string stationId;
		private List<Parcel> parcels;

		public IngestStation(string termianlId)
		{
			parcels = new List<Parcel>();
			StationId = termianlId;
		}

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
					Double volume = 0;
					foreach (Parcel p in targetParcels)
						volume += p.GetVolume();
					return Math.Round(volume, 2).ToString() + " m3";
					break;

				case DataType.Weight:
					double weight = 0;
					foreach (Parcel p in targetParcels)
						weight += p.Weight;
					return Math.Round(weight/1000.0, 2).ToString() + " Kg";
			}
			return "n/a";
		}

		internal void RegisterParcel(DateTime date, int weight, int length, int height, int width)
		{
			parcels.Add(new Parcel(date, weight, length, height, width));
		}
	}
}