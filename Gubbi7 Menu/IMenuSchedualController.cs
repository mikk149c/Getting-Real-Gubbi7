using System;
using System.Collections.Generic;
using System.Text;

namespace Gubbi7_Menu
{
	public interface IMenuSchedualController
	{
		IEnumerable<string> GetScheduleNames();
		void DeleteSchedule(string name);
	}
}
