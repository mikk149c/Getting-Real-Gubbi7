using System;

namespace Smart_Menu
{
	public class Menu
	{
		private string name;
		public string Name { get { return name; } set { name = value; } }
		public Menu(string name)
		{
			Name = name;
		}

		public void AddMenuPoint(IMenuPoint menuPoint)
		{
			throw new NotImplementedException();
		}

		public void Activate()
		{
			throw new NotImplementedException();
		}
	}
}
