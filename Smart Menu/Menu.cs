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
            DisplayMenu();
            if (!menuPointList.Count.Equals(0))
            {
                ConsoleKey key;
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        MovePointerUp();
                        break;
                    case ConsoleKey.DownArrow:
                        MovePointerDown();
                        break;
                    case ConsoleKey.Enter:
                         Console.Clear();
                        menuPointList[pointer].Invoke();
                        DisplayMenu();
                        break;
                    
                }
                    
            }

		}

        private void MovePointerDown()
        {
            MovePointer(1);
        }

        private void MovePointerUp()
        {
            MovePointer(-1);
        }

        private void MovePointer(int v)
        {
            
        }

        public void DisplayMenu()
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
