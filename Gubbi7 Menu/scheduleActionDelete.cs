using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ScheduleActionDelete : IMenuPoint
	{
		private IMenuSchedualController scheduleController;
		private string name;

		public ScheduleActionDelete(IMenuSchedualController scheduleController, string name)
		{
			this.scheduleController = scheduleController;
			this.name = name;
		}

		public string GetMenuPointName()
		{
			return "Slet";
		}

		public void Invoke()
		{
			if (MenuUtility.ConfirmAction($"slette {name}"))
			scheduleController.DeleteSchedule(name);
		}
	}
}