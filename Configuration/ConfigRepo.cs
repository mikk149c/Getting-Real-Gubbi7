using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationData
{
	public class ConfigRepo
	{
		private List<Configuration> configurations;
		public ConfigRepo()
		{
			configurations = new List<Configuration>();
			configurations.Add(new Configuration("Test"));
		}

		public List<Configuration> Configurations { get { return configurations; } }

		public void Add(string name, DateTime startTime, DateTime endTime, bool realativeTime, TimeSpan interval, List<string> data)
		{
			List<DataType> dataTypes = ParsListOfDataTypes(data);
			Configuration configuration = new Configuration(name, startTime, endTime, realativeTime, interval, dataTypes);
			configurations.Add(configuration);
		}

		public static List<DataType> ParsListOfDataTypes(List<string> data)
		{
			List<DataType> dataTypes = new List<DataType>();
			foreach (string s in data)
				dataTypes.Add((DataType)Enum.Parse(typeof(DataType), s));
			return dataTypes;
		}

	}
}
