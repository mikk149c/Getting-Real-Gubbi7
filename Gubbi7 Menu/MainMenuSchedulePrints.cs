using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class MainMenuSchedulePrints : IMenuPoint
	{
		private SchedualController scheduleController;

		public MainMenuSchedulePrints()
		{
			this.scheduleController = SchedualController.Instance;
		}

		public string GetMenuPointName()
		{
			return "Planlagte print";
		}

		public void Invoke()
		{
			Menu selectScheduleMenu = new Menu("Planlagte print");
			selectScheduleMenu.ExitAfterInWoke = true;
			foreach (string s in scheduleController.GetScheduleNames())
			{
				selectScheduleMenu.AddMenuPoint(new ScheduleActionMenu(s));
			}

			selectScheduleMenu.Activate();
		}
	}
}