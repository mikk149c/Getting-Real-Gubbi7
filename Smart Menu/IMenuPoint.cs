using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Menu
{
	// interface med 2 metoder, en metode der skal returnere en string "GetMenuPointName" og en void metode som 
	// udfører koden den pågældende string beskriver
	public interface IMenuPoint
	{
		string GetMenuPointName();
		void Invoke();
	}
}
