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

		internal Configuration(string name, DateTime startTime, DateTime endTime, bool realativeTime, TimeSpan interval, List<DataType> data)
		{
			this.Name = name;
			this.StartTime = startTime;
			this.EndTime = endTime;
			this.RealativeTime = realativeTime;
			this.Interval = interval;
			this.Data = data;
		}

		public Configuration(string name)
		{
			this.Name = name;
			Data = new List<DataType> { DataType.Waight, DataType.Volume, DataType.Amount };
		}

		public string Name { get => name; set => name = value; }
		public DateTime StartTime { get => startTime; set => startTime = value; }
		public DateTime EndTime { get => endTime; set => endTime = value; }
		public bool RealativeTime { get => realativeTime; set => realativeTime = value; }
		public TimeSpan Interval { get => interval; set => interval = value; }
		public List<DataType> Data { get => data; set => data = value; }
	}
}
