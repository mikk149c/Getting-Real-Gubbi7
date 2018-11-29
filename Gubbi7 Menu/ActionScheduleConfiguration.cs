using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ActionScheduleConfiguration : IMenuPoint
	{
		private ConfigController configController;
		private string name;

		public ActionScheduleConfiguration(ConfigController configController, string name)
		{
			this.configController = configController;
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