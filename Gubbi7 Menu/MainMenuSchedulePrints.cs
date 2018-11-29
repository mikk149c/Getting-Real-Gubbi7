using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class MainMenuSchedulePrints : IMenuPoint
	{
		private ScheduleController scheduleController;

		public MainMenuSchedulePrints(ScheduleController scheduleController)
		{
			this.scheduleController = scheduleController;
		}

		public string GetMenuPointName()
		{
			return "Planlagte print";
		}

		public void Invoke()
		{
			Menu 
		}
	}
}