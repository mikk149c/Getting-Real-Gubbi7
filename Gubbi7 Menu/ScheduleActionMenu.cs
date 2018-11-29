using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ScheduleActionMenu : IMenuPoint
	{
		private ScheduleController scheduleController;
		private string name;

		public ScheduleActionMenu(ScheduleController scheduleController, string s)
		{
			this.scheduleController = scheduleController;
			this.name = s;
		}

		public string GetMenuPointName()
		{
			return name;
		}

		public void Invoke()
		{
			Menu ActionMenu = new Menu("Handling");
			ActionMenu.AddMenuPoint(new ScheduleActionDelete(scheduleController, name));
			ActionMenu.Activate();
		}
	}
}