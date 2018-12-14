using System;

namespace CoreDataStructure
{
	internal class Parcel
	{
		private DateTime time;
		private int weight;
		private int height;
		private int width;
		private int length;
		private int lengthScalingFactor = 1000;

		public Parcel(DateTime date, int weight, int length, int height, int width)
		{
			Time = date;
			Weight = weight;
			Length = length;
			Height = height;
			Width = width;
		}

		public int Weight { get { return weight; } set { weight = value; } }
		public int Height { get { return height; } set { height = value; } }
		public int Width { get { return width; } set { width = value; } }
		public int Length { get { return length; } set { length = value; } }
		public DateTime Time { get => time; set => time = value; }

		internal double GetVolume()
		{
			return (double)Height/lengthScalingFactor * (double)Width /lengthScalingFactor * (double)Length /lengthScalingFactor;
		}
	}
}