using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class MainMenuSchedulePrints : IMenuPoint
	{
		// opretter privat objekt af schedualController
		private SchedualController scheduleController;

		//objektet sættes = med singleton instans af "SchedualController
		public MainMenuSchedulePrints()
		{
			this.scheduleController = SchedualController.Instance;
		}
		// navn for menupunkt
		public string GetMenuPointName()
		{
			return "Planlagte print";
		}


		// Opretter menupunkt "Planlagte print" Den illustrerer planlagte print i systemet.
		// der eksisterer dog kun stub planlagte print i systemet og kan ikke laves på nuværende tidspunkt.
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