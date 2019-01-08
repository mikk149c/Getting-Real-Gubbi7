using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{'
	//STUBKODE
	public class SchedualController
	{
		private static SchedualController instance;

		private SchedualController()
		{

		}
		// Singleton
		public static SchedualController Instance
		{
			get
			{
				if (instance == null)
					instance = new SchedualController();
				return instance;
			}
		}

		public void DeleteSchedule(string name)
		{
			throw new NotImplementedException();
		}

		public List<string> GetScheduleNames()
		{
			return new List<string> {
				"1",
				"2",
				"3"};
		}
	}
}
