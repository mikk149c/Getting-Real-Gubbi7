using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ActionScheduleConfiguration : IMenuPoint
	{
		private IMenuConfigController configController;
		private string name;

		public ActionScheduleConfiguration(IMenuConfigController configController, string name)
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