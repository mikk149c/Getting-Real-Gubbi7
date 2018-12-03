using Smart_Menu;
using System;

namespace Gubbi7_Menu
{
	internal class MainMenuManualConfiguration : IMenuPoint
	{
		private IMenuConfigController configController;

		public MainMenuManualConfiguration(IMenuConfigController configController)
		{
			this.configController = configController;
		}

		public string GetMenuPointName()
		{
			return "Manuel konfiguration";
		}

		public void Invoke()
		{
			throw new NotImplementedException();
		}
	}
}