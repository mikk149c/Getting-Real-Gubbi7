using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ScheduleActionMenu : IMenuPoint
	{
		private IMenuSchedualController scheduleController;
		private string name;

		public ScheduleActionMenu(IMenuSchedualController scheduleController, string s)
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
			Menu actionMenu = new Menu("Handling");
			actionMenu.AddMenuPoint(new ScheduleActionDelete(scheduleController, name));
			actionMenu.Activate();
		}
	}
}