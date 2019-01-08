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
		// objekter oprettes.
		private static ConfigController instance;
		private ConfigRepo configRepo;

		//instansierer
		private ConfigController()
		{
			configRepo = new ConfigRepo();
		}
		// populære singleton som returnerer samme instans rundt i programmet
		public static ConfigController Instance {
			get
			{
				if (instance == null)
					instance = new ConfigController();
				return instance;
			}
		}
		// Metode som tilføjer en konfiguration til configRepo og skal modtage følgende data:
		/*	string name,
			DateTime startTime,
			DateTime endTime,
			TimeSpan interval,
			List<string> dataTypes,
			bool realativeTime */
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
		// fjerner alle konfigurationer fra listen, hvor input string er = konfigurationsnavn
		// i listen (configRepo.Configurations)
		public void DeleteConfiguration(string name)
		{
			configRepo.Configurations.RemoveAll(x => x.Name.Equals(name));
		}
		// metode der gemmer konfigurationer i en liste, og returnerer listen af navnene på dem.
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
		// returnerer liste over enum datatyper, amount, weight og volume
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
		// IKKE implementeret metode for schedule konfiguration
		public void ScheduleConfiguration(string name)
		{
			throw new NotImplementedException();
		}
	}
}
