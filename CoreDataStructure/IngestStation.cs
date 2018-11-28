using System.Collections.Generic;

namespace CoreDataStructure
{
	internal class IngestStation
	{
		private int stationNumber;
		private List<Parcel> parcels;
		public int StationNumber { get { return stationNumber; } set { stationNumber = value; } }
	}
}