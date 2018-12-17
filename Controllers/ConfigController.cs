using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigurationData;

namespace Controllers
{
	public class ConfigController
	{
		private static ConfigController instance;
		private ConfigRepo configRepo;

		private ConfigController()
		{
			configRepo = new ConfigRepo();
		}

		public static ConfigController Instance {
			get
			{
				if (instance == null)
					instance = new ConfigController();
				return instance;
			}
		}

		public void AddConfiguration(string name, DateTime startTime, DateTime endTime, TimeSpan interval, List<string> dataTypes, bool realativeTime)
		{
			configRepo.Add(
				name,
				startTime,
				endTime,
				realativeTime,
				interval,
				dataTypes
				);
		}

		public void DeleteConfiguration(string name)
		{
			configRepo.Configurations.RemoveAll(x => x.Name.Equals(name));
		}

		public List<string> GetConfigurationNames()
		{
			List<string> configNames = new List<string>();
			foreach (Configuration c in configRepo.Configurations)
				configNames.Add(c.Name);
			return configNames;
		}

		public void PrintConfiguration(string name)
		{
			Configuration config = configRepo.Configurations.Find(x => x.Name == name);
			PrintController.PrintConfig(config);
		}

		public List<string> GetDataTypes()
		{
			return Enum.GetNames(typeof(DataType)).ToList();
		}

		public void PrintConfiguration(string name, DateTime startTime, DateTime endTime, TimeSpan interval, List<string> dataTypes, bool relativeTime)
		{
			PrintController.PrintConfig(new Configuration(
				name,
				startTime,
				endTime,
				relativeTime,
				interval,
				ConfigRepo.ParsListOfDataTypes(dataTypes)
				));
		}

		public void ScheduleConfiguration(string name)
		{
			throw new NotImplementedException();
		}
	}
}
