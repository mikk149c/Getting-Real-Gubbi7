using Smart_Menu;
using System;

namespace Gubbi7_Menu
{
	internal class MainMenuCreateConfiguration : IMenuPoint
	{
		private IMenuConfigController configController;

		public MainMenuCreateConfiguration(IMenuConfigController configController)
		{
			this.configController = configController;
		}

		public string GetMenuPointName()
		{
			return "Ny konfiguration";
		}

		public void Invoke()
		{
			throw new NotImplementedException();
		}
	}
}