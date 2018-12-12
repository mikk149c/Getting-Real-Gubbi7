using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ScheduleActionMenu : IMenuPoint
	{
		private string name;

		public ScheduleActionMenu(string s)
		{
			this.name = s;
		}

		public string GetMenuPointName()
		{
			return name;
		}

		public void Invoke()
		{
			Menu actionMenu = new Menu("Handling");
			actionMenu.ExitAfterInWoke = true;
			actionMenu.AddMenuPoint(new ScheduleActionDelete(name));
			actionMenu.Activate();
		}
	}
}