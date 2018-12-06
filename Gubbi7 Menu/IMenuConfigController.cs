using System;
using System.Collections.Generic;
using System.Text;

namespace Gubbi7_Menu
{
	public interface IMenuConfigController
	{
		void DeleteConfiguration(string name);
		void PrintConfiguration(string name);
		void ScheduleConfiguration(string name);
		IEnumerable<string> GetConfigurationNames();
	}
}
