using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class ScheduleActionDelete : IMenuPoint
	{
		// SINGLETON
		private SchedualController scheduleController;
		private string name;

		public ScheduleActionDelete(string name)
		{
			this.scheduleController = SchedualController.Instance;
			this.name = name;
		}
		// navn
		public string GetMenuPointName()
		{
			return "Slet";
		}
		// 
		public void Invoke()
		{
			// hvis den modtager en true bool, vil den slette den korresponderende schedule konfiguration
			// er ikke implementeret.
			if (MenuUtility.ConfirmAction($"slette {name}"))
			scheduleController.DeleteSchedule(name);
		}
	}
}