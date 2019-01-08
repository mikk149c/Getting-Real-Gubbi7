using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationData
{
	public class Configuration
	{
		private string name;
		private DateTime startTime;
		private DateTime endTime;
		private bool realativeTime;
		private TimeSpan interval;
		private List<DataType> data;

		
		public Configuration(string name, DateTime startTime, DateTime endTime, bool realativeTime, TimeSpan interval, List<DataType> data)
		{
			Name = name;
			StartTime = startTime;
			EndTime = endTime;
			RealativeTime = realativeTime;
			Interval = interval;
			Data = data;
		}
		//Stub should be removed when user added configurations work
		public Configuration(string name)
		{
			Name = name;
			Data = new List<DataType> { DataType.Weight, DataType.Volume, DataType.Amount, DataType.Weight };
			StartTime = new DateTime(2018, 10, 29, 0, 0, 0);
			EndTime = new DateTime(2018, 11, 3, 0, 0, 0);
			Interval = new TimeSpan(0, 1, 0, 0);
		}

		public string Name { get => name; set => name = value; }
		public DateTime StartTime { get => startTime; set => startTime = value; }
		public DateTime EndTime { get => endTime; set => endTime = value; }
		public bool RealativeTime { get => realativeTime; set => realativeTime = value; }
		public TimeSpan Interval { get => interval; set => interval = value; }
		public List<DataType> Data { get => data; set => data = value; }
	}
}
