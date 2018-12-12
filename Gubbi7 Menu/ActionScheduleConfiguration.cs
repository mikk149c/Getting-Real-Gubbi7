using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class ActionScheduleConfiguration : IMenuPoint
	{
		private ConfigController configController;
		private string name;

		public ActionScheduleConfiguration(string name)
		{
			this.configController = ConfigController.Instance;
			this.name = name;
		}

		public string GetMenuPointName()
		{
			return "Planlæg";
		}

		public void Invoke()
		{
			configController.ScheduleConfiguration(name);
		}
	}
}