using Smart_Menu;
using Controllers;
using System;

namespace Gubbi7_Menu
{
	internal class ActionPrintConfiguration : IMenuPoint
	{
		private ConfigController configController;
		private string name;

		public ActionPrintConfiguration(string name)
		{
			this.configController = ConfigController.Instance;
			this.name = name;
		}

		public string GetMenuPointName()
		{
			return "Print";
		}

		public void Invoke()
		{
			Console.WriteLine("Printing file");
			configController.PrintConfiguration(name);
		}
	}
}