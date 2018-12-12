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

		public void DeleteConfiguration(string name)
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
		}

		public void ScheduleConfiguration(string name)
		{
			throw new NotImplementedException();
		}
	}
}
