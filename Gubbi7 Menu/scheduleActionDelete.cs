using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ScheduleActionDelete : IMenuPoint
	{
		private ScheduleController scheduleController;
		private string name;

		public ScheduleActionDelete(ScheduleController scheduleController, string name)
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
			scheduleController.DeleteSchedule(name);
		}
	}
}