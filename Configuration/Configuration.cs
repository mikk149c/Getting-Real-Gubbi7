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
			this.startTime = startTime;
			this.endTime = endTime;
			this.realativeTime = realativeTime;
			this.interval = interval;
			this.data = data;
		}

		public Configuration(string name)
		{
			this.Name = name;
		}

		public string Name { get => name; set => name = value; }
	}
}
