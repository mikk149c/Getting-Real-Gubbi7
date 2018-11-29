using System;
using System.Collections.Generic;


namespace Smart_Menu
{
	public class Menu
	{
		private string mainMenuName;
        private List<IMenuPoint> menuPointList = new List<IMenuPoint>();
        private int pointer = 0;

        public string Name { get { return mainMenuName; } set { mainMenuName = value; } }
		public Menu(string mainMenuName)
		{
			Name = mainMenuName;
		}
        
		public void AddMenuPoint(IMenuPoint menuPoint)
		{
			menuPointList.Add(menuPoint);
		}

		public void Activate()
		{
			Console.Clear();
            DisplayCursor();

		}

        public void DisplayCursor()
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.WriteLine(mainMenuName);
            Console.WriteLine(menuPointList);
            MenuPointCount();
        }
        //Skriver til Konsollen
        public void MenuPointCount()
        {
            for (int i = 0; i < menuPointList.Count; i++)
            {
                DisplaySelect(i);
            }
        }

        private void DisplaySelect(int i)
        {
            if (i.Equals(pointer))
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine(menuPointList[i].GetMenuPointName());
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine(menuPointList[i].GetMenuPointName());
            }
            
        }

    }
}
