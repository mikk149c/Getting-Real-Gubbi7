using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class ScheduleActionDelete : IMenuPoint
	{
		private SchedualController scheduleController;
		private string name;

		public ScheduleActionDelete(string name)
		{
			this.scheduleController = SchedualController.Instance;
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